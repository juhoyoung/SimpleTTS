using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTTS
{
    public partial class ChatingForm : Form
    {
        public ChatingForm()
        {
            InitializeComponent();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                
                //Console.WriteLine(msg.WParam + " " + keyData);
                //String path = System.Windows.Forms.Application.StartupPath + @"1.txt";
                //System.IO.File.AppendAllText(path, msg.WParam + " " + keyData +" \r\n");

                if (keyData.Equals(Keys.Enter))  // 엔터키 눌렀을때 처리
                {
                    //Console.WriteLine(chat_tBox.Text);
                    if (TTS.ts.SaveAudio(chat_tBox.Text, "chat.mp3") == true) // 메세지가 들어있을때만 플레이
                    {
                        TTS.ts.PlayMessage("chat.mp3");
                    }
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
        
        private void ChatingForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("채팅창 열림");
           
            
        }
    }

}
