using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTTS
{
    class OptionControl
    {
        String defaultOption = "m1=도망가자 빨리!\r\n" +
                               "m2=뒤에 적있어 조심해\r\n" +
                               "m3=나는 도망간다 ㅋㅋㅋ\r\n" +
                               "m4=날 위해 희생해\r\n";

        public String loadOption(String oString) // 찾아야되는 옵션 리턴
        {
            String path = System.Windows.Forms.Application.StartupPath + @"\Option.txt"; // 옵션 경로


            String[] sOption; // 분할 될 아이디
            String readID;

            try
            {
                StreamReader OptionList = new StreamReader(path);


                while ((readID = OptionList.ReadLine()) != null)
                {

                    sOption = readID.Split('=');
                    if (sOption[0] == oString)
                    {
                        OptionList.Close(); // 스트림 리더 닫음
                        return sOption[1];
                    }
                }
                


            }
            catch (FileNotFoundException)
            {
                File.Create(path).Close();
                File.WriteAllText(path, defaultOption);
            }

            return null;


        }

        public void saveOption(String option) // 옵션 저장
        {

            String path = System.Windows.Forms.Application.StartupPath + @"\Option.txt"; // 옵션 경로


            try
            {
                File.WriteAllText(path, option);
            }
            catch(FileNotFoundException)
            {
                File.Create(path).Close();
            }
            
        }


    }
}
