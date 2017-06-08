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

namespace SimpleTTS
{
    class TTS
    {

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo); // 키보드 입력


        public static TTS ts = new TTS(); // 싱글톤
        WMPLib.WindowsMediaPlayer wPlayer = new WMPLib.WindowsMediaPlayer();
        private WebClient webClient = new WebClient();
        private string path; // 파일 경로
        private int langType = 0; // 어느나라 사람이 읽는지. 0=한국 1=영어권
        private int voiceType = 0; // 목소리 타입. 0=구글 1=네이버
        private bool isPTT = false; // 눌러서 말하기 사용 여부
        

        public TTS()
        {
            langType = Properties.Settings.Default.lType;
            voiceType = Properties.Settings.Default.vType;
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



            try
            {
                webClient.DownloadFile(getVoiceURL(Message),path); // 음성 파일 다운로드
            }
            catch (WebException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }

            webClient.Dispose();
            return true;
            
        }

        public void PlayMessage(String fName) // 저장된 파일 재생
        {
            Delay(100);

            path = System.Windows.Forms.Application.StartupPath + @"\sound\" + fName;
            
            wPlayer.URL = path;
            
            wPlayer.controls.play();
            
            


        }

        private void WPlayer_StatusChange() // 영상 재생 상태 바뀔때 동작
        {
            // Console.WriteLine(wPlayer.status);

            if (isPTT == true)
            {
                if (wPlayer.status.Equals("중지됨"))
                {
                    keybd_event((byte)Keys.Oemtilde, 0, 0x102, 0); // 손뗌
                }
                else if (wPlayer.status.Contains("재생"))
                {
                    keybd_event((byte)Keys.Oemtilde, 0, 0x100, 0); // 누름
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

        public String getVoiceURL(String Message) // 보이스 주소 구해주기
        {
            String voiceURL = ""; // 목소리 주소

            if (voiceType == 0) // 구글
            {
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
            }
            else if (voiceType == 1)
            {
                switch (langType)
                {
                    case 0: // 한국인
                        voiceURL = "https://m.search.naver.com/p/csearch/ocontent/util/ttsProxy.nhn?service=nco_translate&from=pc_search&speech_fmt=mp3" +
                            "&passportKey=e2f13734bbe4ef5da73790792c00585659b07231&speaker=mijin&text=" + Message;
                        break;
                    case 1: // 영어인
                        voiceURL = "https://m.search.naver.com/p/csearch/ocontent/util/ttsProxy.nhn?service=nco_translate&from=pc_search&speech_fmt=mp3" +
                            "&speed=0&passportKey=e2f13734bbe4ef5da73790792c00585659b07231&speaker=clara&text=" + Message;
                        break;
                    case 2: // 중국인
                        voiceURL = "https://s.search.naver.com/n/tts.cndic/tts/mp3ttsV1.cgi?url=cndic.naver.com&text_fmt=0&pitch=100&volume=100" +
                            "&wrapper=0&enc=0&spk_id=250&speed=80&text=" + Message;
                        break;
                }
            }

            return voiceURL;
        }

        private static DateTime Delay(int MS)
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
