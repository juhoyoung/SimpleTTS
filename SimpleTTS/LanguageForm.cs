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

        /// <summary>
        /// lType  어느 나라 발음        0=한국인 1=미국인 2=중국인
        /// vType  어디 목소리 쓸건지    0=구글   1=네이버
        /// tType  어느 언어로 번역할지  0=영어   1=중국어
        /// </summary>
        /// 
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
            Properties.Settings.Default.lType = LangType_cBox.SelectedIndex;  // 국적
            Properties.Settings.Default.vType = voiceType_cBox.SelectedIndex; // 목소리
            Properties.Settings.Default.isTrans = Trans_checkBox.Checked;     // 번역 여부
            Properties.Settings.Default.tType = tType_cBox.SelectedIndex;     // 번역 언어
            Properties.Settings.Default.clientID = cID_tBox.Text;             // ID
            Properties.Settings.Default.clientSecret = cSecret_tBox.Text;     // secetID

            Properties.Settings.Default.Save(); // 저장

            TTS.ts.setLangType(LangType_cBox.SelectedIndex); // TTS에 현재 타입 전달
            TTS.ts.setVoiceType(voiceType_cBox.SelectedIndex);
            Lang_StatusLabel1.Text = "저장 완료";
        }

        private void LanguageForm_Load(object sender, EventArgs e)
        {
            LangType_cBox.SelectedIndex = Properties.Settings.Default.lType;
            voiceType_cBox.SelectedIndex = Properties.Settings.Default.vType;
            Trans_checkBox.Checked = Properties.Settings.Default.isTrans;
            tType_cBox.SelectedIndex = Properties.Settings.Default.tType;
            cID_tBox.Text = Properties.Settings.Default.clientID;
            cSecret_tBox.Text = Properties.Settings.Default.clientSecret;
        }

        private void Trans_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Lang_StatusLabel1.Text = "1일 최대 1만글자 번역 가능합니다.";
        }
    }
}
