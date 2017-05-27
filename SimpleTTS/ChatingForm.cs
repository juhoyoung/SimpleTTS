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
    public partial class ChatingForm : Form
    {
        TTS ts = new TTS();
        public ChatingForm()
        {
            InitializeComponent();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.Enter))  // 엔터키 눌렀을때 처리
                {
                    //Console.WriteLine(chat_tBox.Text);
                    if (ts.SaveAudio(chat_tBox.Text, "chat.mp3") == false)
                        return true;
                    ts.PlayMessage("chat.mp3");
                    chat_tBox.Text = "";
                    this.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }

}
