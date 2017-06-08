using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTTS
{
    public partial class MainForm : Form
    {
        private MacroForm macroForm = new MacroForm();
        private LanguageForm langForm = new LanguageForm();
        private HotKeyForm hotForm = new HotKeyForm();
        private KeyProcessing kProcess;


        public MainForm()
        {
            InitializeComponent();
            kProcess = new KeyProcessing(this);
            kProcess.SetHook();
        }

        private void OpenMacro_Btn_Click(object sender, EventArgs e) // 매크로 설정창 활성화 시킴
        {
            

            macroForm.ShowDialog(); 
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) // 트레이아이콘 더블 클릭
        {
            this.NotifyIcon.Visible = false;
            this.Show();
        }

        private void Hide_Btn_Click(object sender, EventArgs e) // 숨기기 버튼
        {
            this.NotifyIcon.Visible = true;
            this.Hide();
        }

        private void exit_MenuItem_Click(object sender, EventArgs e) // 트레이 메뉴 종료 버튼
        {
            this.NotifyIcon.Visible = false;
            Application.Exit();
        }

        public void ReStart_KeyProcess()
        {
            //KeyProcessing k = new KeyProcessing();
            kProcess.SetHook();
        }

        private void OpenLang_Btn_Click(object sender, EventArgs e) // 언어 설정창 열기
        {
            langForm.ShowDialog();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kProcess.setStatus(true);
        }

        private void OpenHoyKey_Btn_Click(object sender, EventArgs e) // 단축키 설정창 열기
        {
            hotForm.ShowDialog();
        }
    }
}
