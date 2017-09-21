using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Media;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimpleTTS
{
    class TTS
    {

        /// <summary>
        /// 
        /// mijin : 한국어, 여성 음색
        /// jinho : 한국어, 남성 음색
        /// clara : 영어, 여성 음색
        /// matt  : 영어, 남성 음색
        /// yuri   : 일본어, 여성 음색
        /// shinji : 일본어, 남성 음색
        /// meimei     : 중국어, 여성 음색
        /// liangliang : 중국어, 남성 음색
        /// jose   : 스페인어, 남성 음색
        /// carmen : 스페인어, 여성 음색
        ///
        private String[,] Array_Speaker = { {"mijin" , "jinho"} ,
                                      {"clara" , "matt" },
                                      {"meimei", "liangliang" } };  // 네이버 목소리 주인 이름

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo); // 키보드 입력

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern short VkKeyScanEx(char ch, IntPtr dwhkl);


        public static TTS ts = new TTS(); // 싱글톤
        WMPLib.WindowsMediaPlayer wPlayer = new WMPLib.WindowsMediaPlayer();
        private WebClient webClient = new WebClient();
        private string path; // 파일 경로
        private int langType = 0; // 어느나라 사람이 읽는지. 0=한국 1=영어권
        private int voiceType = 0; // 목소리 타입. 0=구글 1=네이버
        private bool isPTT = false; // 눌러서 말하기 사용 여부
        private double pbSpeed = 1.0;


        public TTS()
        {
            langType = Properties.Settings.Default.lType;
            voiceType = Properties.Settings.Default.vType;
            isPTT = Properties.Settings.Default.isPTT;
            pbSpeed = Properties.Settings.Default.IPbSpeed / 10.0;
            wPlayer.StatusChange += WPlayer_StatusChange; // 이벤트 등록
            //Console.WriteLine("TTS 생성");
        }

        public void setLangType(int Type) // 0=한국인 1=미국인 2=중국인
        {
            langType = Type;
        }

        public void setVoiceType(int Type) // 목소리 종류 설정
        {
            voiceType = Type;
        }

        public void setPTT(bool isPTT) // 푸시 투 토크 쓸건지.
        {
            this.isPTT = isPTT;
        }

        public void setPbSpeed(double pbSpeed) // 재생 속도 설정
        {
            this.pbSpeed = pbSpeed;
        }


        public bool SaveAudio(String Message, String fName) // TTS 파일 저장
        {
            if(Message.Equals("")) // 아무런 메시지 입력되지 않았을때 처리 안함
            {
                return false;
            }
            path = System.Windows.Forms.Application.StartupPath + @"\sound\"+fName;

            DirectoryInfo dir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + @"\sound\"); 

            if (dir.Exists == false) // 폴더 존재하지 않으면 생성
            {
                dir.Create();
            }

            wPlayer.URL = System.Windows.Forms.Application.StartupPath + @"\sound\dummy.mp3"; // 더미파일 재생
            wPlayer.controls.play();


            if (Properties.Settings.Default.isTrans == true) // 번역 여부
            {
                String transMessage = NaverTranslateAPI.instance.translate(Message);
                Console.WriteLine(transMessage);
                if (!transMessage.Equals("")) // 공백 리턴되면 오류가 있는거임.
                {
                    langType = Properties.Settings.Default.tType+1; // 한국어가 빠지기 때문에 인덱스가 1 작음
                    Message = transMessage;
                }
            }


            if (voiceType == 0) // 구글 음성
            {
                try
                {
                    webClient.DownloadFile(getVoiceURL(Message), path); // 음성 파일 다운로드
                }
                catch (WebException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else // 네이버 음성
            {
                getVoice(Message, path);
            }

            webClient.Dispose();
            return true;
            
        }

        public void PlayMessage(String fName) // 저장된 파일 재생
        {
            Delay(100);

            path = System.Windows.Forms.Application.StartupPath + @"\sound\" + fName;

            if (pbSpeed == 0)
                pbSpeed = 0.1;

            wPlayer.URL = path;
            wPlayer.settings.rate = pbSpeed;
            wPlayer.controls.play();
            
        }

        private void WPlayer_StatusChange() // 영상 재생 상태 바뀔때 동작
        {
            // Console.WriteLine(wPlayer.status);
            char KeyPTT;
            short VkCodePTT;
            KeyPTT = char.Parse(OptionController.instance.GetHotKeyPTT());
            VkCodePTT = VkKeyScanEx(KeyPTT, IntPtr.Zero);

            
            if (isPTT == true)
            {
                if (wPlayer.status.Equals("중지됨"))
                {
                    keybd_event((byte)VkCodePTT, 0, 0x102, 0); // 손뗌
                }
                else if (wPlayer.status.Contains("재생"))
                {
                    keybd_event((byte)VkCodePTT, 0, 0x100, 0); // 누름
                }
            }
        }

        public bool fileExist(String fName) // 파일 존재 여부
        {

            path = System.Windows.Forms.Application.StartupPath + @"\sound\" + fName;
            System.IO.FileInfo file = new System.IO.FileInfo(path);

            if (file.Exists)
                return true;
            else
                return false;

        }

        private String getVoiceURL(String Message) // Google TSS
        {
            String voiceURL = ""; // 목소리 주소
            
            switch (langType)
            {
                case 0: // 한국인
                    voiceURL = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + Message + "&tl=ko-kr";
                    break;
                case 1: // 영어인
                    voiceURL = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + Message + "&tl=en";
                    break;
                case 2: // 중국인
                    voiceURL = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + Message + "&tl=zh-CN";
                    break;
            }


            return voiceURL;
        }






        private void getVoice(String Message, String path) // Naver API
        {
            string speaker = Array_Speaker[langType, voiceType-1];

            string text = Message; // 음성합성할 문자값
            string url = "https://openapi.naver.com/v1/voice/tts.bin";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Headers.Add("X-Naver-Client-Id", Properties.Settings.Default.SclientID);
            request.Headers.Add("X-Naver-Client-Secret", Properties.Settings.Default.SclientSecret);

            request.Method = "POST";
            byte[] byteDataParams = Encoding.UTF8.GetBytes("speaker=" + speaker + "&speed=0&text=" + text);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string status = response.StatusCode.ToString();
                Console.WriteLine("Naver status=" + status);


                using (Stream output = File.Create(path))
                using (Stream input = response.GetResponseStream())
                {
                    input.CopyTo(output);
                }
            }
            catch(WebException e) // 예외 처리
            {
                Console.WriteLine(e.ToString());
                Regex reg = new Regex(@"\d{3}");
                Match result = reg.Match(e.ToString());

                switch (result.ToString())
                {
                    case "401":
                        MessageBox.Show("음성합성란의 클라이언트 아이디와 시크릿 값을 확인해주세요.");
                        break;
                    case "429":
                        MessageBox.Show("음성합성 1일 허용량을 초과하였습니다. 한국인과 함께하세요.");
                        break;
                }
            }

        }

        

        private static DateTime Delay(int MS) // 딜레이
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
    }
}
