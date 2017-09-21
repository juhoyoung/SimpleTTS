using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTTS
{
    class OptionController
    {
        public static OptionController instance = new OptionController();

        ////////////////////////////////////////////////////
        /// <summary>
        /// 단축키 관련
        /// Option 1 = Ctrl   2 = Alt   3 = Shift
        /// </summary>
        private string HotKeyChat;
        private int HotKeyChatOption;
        private string HotKeyMacro1;
        private int HotKeyMacro1Option;
        private string HotKeyMacro2;
        private int HotKeyMacro2Option;
        private string HotKeyMacro3;
        private int HotKeyMacro3Option;
        private string HotKeyMacro4;
        private int HotKeyMacro4Option;
        private string HotKeyPTT;

        public OptionController()
        {
            HotKeyChat = Properties.Settings.Default.HotKeyChat;
            HotKeyChatOption = Properties.Settings.Default.HotKeyChatOption;

            HotKeyMacro1 = Properties.Settings.Default.HotKeyMacro1;
            HotKeyMacro1Option = Properties.Settings.Default.HotKeyMacro1Option;

            HotKeyMacro2 = Properties.Settings.Default.HotKeyMacro2;
            HotKeyMacro2Option = Properties.Settings.Default.HotKeyMacro2Option;

            HotKeyMacro3 = Properties.Settings.Default.HotKeyMacro3;
            HotKeyMacro3Option = Properties.Settings.Default.HotKeyMacro3Option;

            HotKeyMacro4 = Properties.Settings.Default.HotKeyMacro4;
            HotKeyMacro4Option = Properties.Settings.Default.HotKeyMacro4Option;

            HotKeyPTT = Properties.Settings.Default.HotKeyPTT;
        }

        public void SetHotKeyChat(string HotKeyChat)
        {
            this.HotKeyChat = HotKeyChat;
        }
        
        public string GetHotKeyChat()
        {
            return HotKeyChat;
        }

        public void SetHotKeyChatOption(int HotKeyChatOption)
        {
            this.HotKeyChatOption = HotKeyChatOption;
        }

        public int GetHotKeyChatOption()
        {
            return HotKeyChatOption;
        }

        public void SetHotKeyMacro1(string HotKeyMacro1)
        {
            this.HotKeyMacro1 = HotKeyMacro1;
        }

        public string GetHotKeyMacro1()
        {
            return HotKeyMacro1;
        }

        public void SetHotKeyMacro2(string HotKeyMacro2)
        {
            this.HotKeyMacro2 = HotKeyMacro2;
        }

        public string GetHotKeyMacro2()
        {
            return HotKeyMacro2;
        }

        public void SetHotKeyMacro3(string HotKeyMacro3)
        {
            this.HotKeyMacro3 = HotKeyMacro3;
        }

        public string GetHotKeyMacro3()
        {
            return HotKeyMacro3;
        }

        public void SetHotKeyMacro4(string HotKeyMacro4)
        {
            this.HotKeyMacro4 = HotKeyMacro4;
        }

        public string GetHotKeyMacro4()
        {
            return HotKeyMacro4;
        }

        public void SetHotKeyMacro1Option(int HotKeyMacro1Option)
        {
            this.HotKeyMacro1Option = HotKeyMacro1Option;
        }

        public int GetHotKeyMacro1Option()
        {
            return HotKeyMacro1Option;
        }

        public void SetHotKeyMacro2Option(int HotKeyMacro2Option)
        {
            this.HotKeyMacro2Option = HotKeyMacro2Option;
        }

        public int GetHotKeyMacro2Option()
        {
            return HotKeyMacro2Option;
        }

        public void SetHotKeyMacro3Option(int HotKeyMacro3Option)
        {
            this.HotKeyMacro3Option = HotKeyMacro3Option;
        }

        public int GetHotKeyMacro3Option()
        {
            return HotKeyMacro3Option;
        }

        public void SetHotKeyMacro4Option(int HotKeyMacro4Option)
        {
            this.HotKeyMacro4Option = HotKeyMacro4Option;
        }

        public int GetHotKeyMacro4Option()
        {
            return HotKeyMacro4Option;
        }

        public void SetHotKeyPTT(string HotKeyPTT)
        {
            this.HotKeyPTT = HotKeyPTT;
        }

        public string GetHotKeyPTT()
        {
            return HotKeyPTT;
        }


        public void SaveHotKey() // 단축키 창에서 저장
        {
            Properties.Settings.Default.HotKeyChat = HotKeyChat;
            Properties.Settings.Default.HotKeyChatOption = HotKeyChatOption;

            Properties.Settings.Default.HotKeyMacro1 = HotKeyMacro1;
            Properties.Settings.Default.HotKeyMacro1Option = HotKeyMacro1Option;

            Properties.Settings.Default.HotKeyMacro2 = HotKeyMacro2;
            Properties.Settings.Default.HotKeyMacro2Option = HotKeyMacro2Option;

            Properties.Settings.Default.HotKeyMacro3 = HotKeyMacro3;
            Properties.Settings.Default.HotKeyMacro3Option = HotKeyMacro3Option;

            Properties.Settings.Default.HotKeyMacro4 = HotKeyMacro4;
            Properties.Settings.Default.HotKeyMacro4Option = HotKeyMacro4Option;

            Properties.Settings.Default.HotKeyPTT = HotKeyPTT;

            Properties.Settings.Default.Save();
        }



    }
}
