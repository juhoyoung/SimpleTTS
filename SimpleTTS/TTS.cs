using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Net;
using System.Threading;

namespace SimpleTTS
{
    class TTS
    {
        public static TTS ts = new TTS(); // 싱글톤
        WMPLib.WindowsMediaPlayer wPlayer = new WMPLib.WindowsMediaPlayer();
        private WebClient webClient = new WebClient();
        private string path; // 파일 경로
        private int langType = 0; // 어느나라 사람이 읽는지. 0=한국 1=영어권
        private int voiceType = 0; // 목소리 타입. 0=구글 1=네이버
        

        public TTS()
        {
            langType = Properties.Settings.Default.lType;
            voiceType = Properties.Settings.Default.vType;
            //Console.WriteLine("TTS 생성");
        }

        public void setLangType(int Type) // 0=한국 1=영어권
        {
            langType = Type;
        }

        public void setVoiceType(int Type) // 목소리 종류 설정
        {
            voiceType = Type;
        }



        public bool SaveAudio(String Message, String fName) // TTS 파일 저장
        {
            if(Message.Equals("")) // 아무런 메시지 입력되지 않았을때 처리 안함
            {
                return false;
            }
            path = System.Windows.Forms.Application.StartupPath + @"\sound\"+fName;

            wPlayer.URL = System.Windows.Forms.Application.StartupPath + @"\sound\dummy.mp3"; // 더미파일 재생
            wPlayer.controls.play();
            
            try
            {
                webClient.DownloadFile(getVoiceURL(Message),path);
            }
            catch (WebException e)
            {
                Console.Write(e.ToString());
            }
            catch (IOException)
            {
                    
            }

            webClient.Dispose();
            return true;
            
        }

        public void PlayMessage(String fName) // 저장된 파일 재생
        {
            Delay(100);
            //Console.WriteLine(fName + " 재생 합니다.");
            path = System.Windows.Forms.Application.StartupPath + @"\sound\" + fName;

            wPlayer.URL = path;
            wPlayer.controls.play();
            


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
