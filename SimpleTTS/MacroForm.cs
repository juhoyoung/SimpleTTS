using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTTS
{
    public partial class MacroForm : Form
    {
        
        String[] old_mText = new String[4]; // 원래 저장 되어있던 텍스트
        OptionControl oCtr = new OptionControl();
        

        public MacroForm()
        {
            
            InitializeComponent();

            if ((macro1_tBox.Text = oCtr.loadOption("m1")) != null) // 텍스트박스 초기화
            {
                macro2_tBox.Text = oCtr.loadOption("m2");
                macro3_tBox.Text = oCtr.loadOption("m3");
                macro4_tBox.Text = oCtr.loadOption("m4");
            }

            /*
            old_mText[0] = macro1_tBox.Text; // 텍스트박스 내용 변화를 체크하기 위한..
            old_mText[1] = macro2_tBox.Text;
            old_mText[2] = macro3_tBox.Text;
            old_mText[3] = macro4_tBox.Text;
            */

            old_mText[0] = "";
            old_mText[1] = "";
            old_mText[2] = "";
            old_mText[3] = "";
        }

        private void Submit_Btn_Click(object sender, EventArgs e) // 확인 버튼
        {
            Macro_StatusLabel1.Text = "";
            this.Close();
        }

        private void Save_Btn_Click(object sender, EventArgs e) // 저장 버튼
        {
            
            String option = "m1=" + macro1_tBox.Text + "\r\nm2=" + macro2_tBox.Text + "\r\nm3=" + macro3_tBox.Text + "\r\nm4=" + macro4_tBox.Text;
            Macro_StatusLabel1.Text = "저장 완료";
            Console.WriteLine(option);
            
            CheckText(0, macro1_tBox.Text);
            CheckText(1, macro2_tBox.Text);
            CheckText(2, macro3_tBox.Text);
            CheckText(3, macro4_tBox.Text);
            

            oCtr.saveOption(option);

        }

        private void CheckText(int index, String newText)  // 내용이 다르거나 음성파일 없을때 생성
        {
            String fName = "macro" + index + ".mp3";

            if (!old_mText[index].Equals(newText) || TTS.ts.fileExist(fName)) 
            {
                old_mText[index] = newText;
                TTS.ts.SaveAudio(newText, fName); // 오디오 저장
            }
            
        }

    }
}
