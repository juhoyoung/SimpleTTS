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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            KeyProcessing k = new KeyProcessing();
            
        }

        private void OpenMacro_Btn_Click(object sender, EventArgs e)
        {
            MacroForm mForm = new MacroForm();


            mForm.ShowDialog(); // 매크로 설정창 활성화 시킴
        }





    }
}
