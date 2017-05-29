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
        WebClient webClient = new WebClient();
        string path;


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
                webClient.DownloadFile("https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + Message + "&tl=ko-kr",
                    path);
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
