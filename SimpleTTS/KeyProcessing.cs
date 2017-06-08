using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices; 

namespace SimpleTTS
{
    class KeyProcessing
    {

        
        private bool statusExit = false;
        static ChatingForm chatForm = new ChatingForm();
        static bool KeyDown = false;
        static int vkCode;
        static MainForm mForm;

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);





        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_ALTDOWN = 0x104;
        const int WM_KEYUP = 0x101;
        const int WM_ALTUP = 0x105;

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;




        public KeyProcessing(MainForm _mForm)
        {
            mForm = _mForm;
            //SetHook();
        }
        ~KeyProcessing()
        {
            Console.WriteLine("KeyProcessing 소멸자 호출되었습니다.");

            if (statusExit == true)
            {
                UnHook();
                //Console.WriteLine("KeyProcessing 소멸자 호출 되었습니다.");
            }
            else
            {
                //MainForm mf = new MainForm();
                //mf.ReStart_KeyProcess();
                mForm.ReStart_KeyProcess();
            }
                
           
        }


        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            
            //Console.WriteLine(code + " W=" + wParam + " I=" + Marshal.ReadInt32(lParam));

            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && KeyDown == false)
            {
                vkCode = Marshal.ReadInt32(lParam);

                if (vkCode.ToString() == "162") // ctrl 키 눌렀을때
                {
                    KeyDown = true;
                }
                
                //return (IntPtr)1;
            }
            else if (code >= 0 && wParam == (IntPtr)WM_KEYUP) 
            {
                vkCode = Marshal.ReadInt32(lParam);

                if (vkCode.ToString() == "162") // ctrl 키 뗐을때
                {
                    KeyDown = false;               
                }
                
                //return (IntPtr)1;
            }
            else if (code >= 0 && wParam == (IntPtr)WM_ALTDOWN) // ALT 키 눌렀을때
            {
                
                vkCode = Marshal.ReadInt32(lParam);


                if (vkCode.ToString() == "49")  // 1번 누름
                {
                    TTS.ts.PlayMessage("macro0.mp3");
                }
                else if (vkCode.ToString() == "50")  // 2번 누름
                {
                    TTS.ts.PlayMessage("macro1.mp3");
                }
                else if (vkCode.ToString() == "51")  // 3번 누름
                {
                    TTS.ts.PlayMessage("macro2.mp3");
                }
                else if (vkCode.ToString() == "52")  // 4번 누름
                {
                    TTS.ts.PlayMessage("macro3.mp3");
                }

                //return (IntPtr)1;
                //return CallNextHookEx(hhook, code, (int)wParam, lParam);
            }



            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && KeyDown == true)
            {
                vkCode = Marshal.ReadInt32(lParam);

                if (vkCode.ToString() == "222")  // ' 누를시 채팅창 띄움
                {
                    try
                    {
                        chatForm.ShowDialog();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
            }

            return CallNextHookEx(hhook, code, (int)wParam, lParam);
            
        }


        public void setStatus(bool status)
        {
            Console.WriteLine("Status 변화 " + status);
            statusExit = status;
        }

    }
}
