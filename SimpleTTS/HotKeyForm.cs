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
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
