using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTTS
{
    public partial class HotKeyForm : Form
    {
        public HotKeyForm()
        {
            InitializeComponent();
            KeyChat_comboBox.SelectedItem = Properties.Settings.Default.HotKeyChat;
            KeyChatOption_comboBox.SelectedIndex = Properties.Settings.Default.HotKeyChatOption;

            KeyMacro1_comboBox.SelectedItem = Properties.Settings.Default.HotKeyMacro1;
            KeyMacro1Option_comboBox.SelectedIndex = Properties.Settings.Default.HotKeyMacro1Option;

            KeyMacro2_comboBox.SelectedItem = Properties.Settings.Default.HotKeyMacro2;
            KeyMacro2Option_comboBox.SelectedIndex = Properties.Settings.Default.HotKeyMacro2Option;

            KeyMacro3_comboBox.SelectedItem = Properties.Settings.Default.HotKeyMacro3;
            KeyMacro3Option_comboBox.SelectedIndex = Properties.Settings.Default.HotKeyMacro3Option;

            KeyMacro4_comboBox.SelectedItem = Properties.Settings.Default.HotKeyMacro4;
            KeyMacro4Option_comboBox.SelectedIndex = Properties.Settings.Default.HotKeyMacro4Option;

            KeyPTT_comboBox.SelectedItem = Properties.Settings.Default.HotKeyPTT;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            hKey_StatusLabel1.Text = "저장 완료";
            OptionController.instance.SaveHotKey();
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            hKey_StatusLabel1.Text = "";
            this.Close();
        }

        private void KeyChatOption_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyChatOption(KeyChatOption_comboBox.SelectedIndex);
            hKey_StatusLabel1.Text = "선택 확인";
        }

        private void KeyChat_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyChat(KeyChat_comboBox.SelectedItem.ToString());
            hKey_StatusLabel1.Text = "채팅 단축키 선택 확인";
        }

        private void KeyMacro1Option_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro1Option(KeyMacro1Option_comboBox.SelectedIndex);
            hKey_StatusLabel1.Text = "선택 확인";
        }

        private void KeyMacro1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro1(KeyMacro1_comboBox.SelectedItem.ToString());
            hKey_StatusLabel1.Text = "매크로1 단축키 선택 확인";
        }

        private void KeyMacro2Option_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro2Option(KeyMacro2Option_comboBox.SelectedIndex);
            hKey_StatusLabel1.Text = "선택 확인";
        }

        private void KeyMacro2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro2(KeyMacro2_comboBox.SelectedItem.ToString());
            hKey_StatusLabel1.Text = "매크로2 단축키 선택 확인";
        }

        private void KeyMacro3Option_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro3Option(KeyMacro3Option_comboBox.SelectedIndex);
            hKey_StatusLabel1.Text = "선택 확인";
        }

        private void KeyMacro3_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro3(KeyMacro3_comboBox.SelectedItem.ToString());
            hKey_StatusLabel1.Text = "매크로3 단축키 선택 확인";
        }

        private void KeyMacro4Option_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro4Option(KeyMacro4Option_comboBox.SelectedIndex);
            hKey_StatusLabel1.Text = "선택 확인";
        }

        private void KeyMacro4_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyMacro4(KeyMacro4_comboBox.SelectedItem.ToString());
            hKey_StatusLabel1.Text = "매크로4 단축키 선택 확인";
        }

        private void KeyPTT_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionController.instance.SetHotKeyPTT(KeyPTT_comboBox.SelectedItem.ToString());
            hKey_StatusLabel1.Text = "PTT 단축키 선택 확인";
        }
    }
}
