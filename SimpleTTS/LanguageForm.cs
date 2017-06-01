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
    public partial class LanguageForm : Form
    {
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            Lang_StatusLabel1.Text = "";
            this.Close();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lType = LangType_cBox.SelectedIndex; // 인덱스값 입력
            Properties.Settings.Default.vType = voiceType_cBox.SelectedIndex;

            Properties.Settings.Default.Save(); // 저장

            TTS.ts.setLangType(LangType_cBox.SelectedIndex); // TTS에 현재 타입 전달
            TTS.ts.setVoiceType(voiceType_cBox.SelectedIndex);
            Lang_StatusLabel1.Text = "저장 완료";
        }

        private void LanguageForm_Load(object sender, EventArgs e)
        {
            LangType_cBox.SelectedIndex = Properties.Settings.Default.lType;
            voiceType_cBox.SelectedIndex = Properties.Settings.Default.vType;
        }
    }
}
