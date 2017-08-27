using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleTTS
{
    class NaverTranslateAPI
    {
        public static NaverTranslateAPI instance = new NaverTranslateAPI();
        private String[] language = {"en", "zh-CN"};


        public String translate(String Message)
        {
            
            string url = "https://openapi.naver.com/v1/language/translate";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            
            request.Headers.Add("X-Naver-Client-Id", Properties.Settings.Default.TclientID); // 네이버에서 받아야함 ID
            request.Headers.Add("X-Naver-Client-Secret", Properties.Settings.Default.TclientSecret); // secret
            request.Method = "POST";

            
            byte[] byteDataParams = Encoding.UTF8.GetBytes("source=ko&target=" +  language[Properties.Settings.Default.tType] + "&text=" + Message); // 영어
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);

                string text = reader.ReadToEnd();
                int startIndex = text.IndexOf("translatedText") + 17;
                int length = text.LastIndexOf('"') - startIndex;

                stream.Close();
                response.Close();
                reader.Close();

                return text.Substring(startIndex, length); // 번역한 문장 리턴

            }
            catch(WebException e)
            {
                Regex reg = new Regex(@"\d{3}");
                Match result = reg.Match(e.ToString());

                switch(result.ToString())
                {
                    case "401": 
                        MessageBox.Show("번역란의 클라이언트 아이디와 시크릿 값을 확인해주세요.");
                        break;
                    case "429":
                        MessageBox.Show("번역 1일 허용량을 초과하였습니다. 한국인과 함께하세요.");
                        break;
                }

                return "";
            }

        }



    }
}
