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
        static bool CtrlKeyDown = false;
        static bool ShiftKeyDown = false;
        static int vkCode;
        static int oldvkCode = 0;
        static MainForm mForm;

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("user32.dll")]
        static extern uint MapVirtualKeyEx(uint uCode, uint uMapType, IntPtr dwhkl);



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


            vkCode = Marshal.ReadInt32(lParam);


            // 계속 키 누르고있을때 반복해서 함수호출 막는 부분
            if (vkCode.ToString() != "161" && vkCode.ToString() != "162" && vkCode.ToString() != "163" && vkCode.ToString() != "164") 
            {
                if (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_ALTDOWN)
                {
                    if (vkCode == oldvkCode)
                    {
                        return CallNextHookEx(hhook, code, (int)wParam, lParam);
                    }
                    else
                    {
                        oldvkCode = vkCode;
                    }
                }
                else if(wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_ALTUP)
                {
                    oldvkCode = 0;
                }
            }

            Console.WriteLine(code + " W=" + wParam + " I=" + Marshal.ReadInt32(lParam));


            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && (CtrlKeyDown == false && ShiftKeyDown == false))
            {
                if (vkCode.ToString() == "162") // ctrl 키 눌렀을때
                {
                    Console.WriteLine("컨트롤 누름");
                    CtrlKeyDown = true;
                }
                else if (vkCode.ToString() == "160" || vkCode.ToString() == "161") // shift 키 눌렀을때
                {
                    Console.WriteLine("쉬프트 누름");
                    ShiftKeyDown = true;
                }

                //return (IntPtr)1;
            }
            else if (code >= 0 && wParam == (IntPtr)WM_KEYUP) 
            {
                if (vkCode.ToString() == "162") // ctrl 키 뗐을때
                {
                    CtrlKeyDown = false;               
                }
                else if (vkCode.ToString() == "160" || vkCode.ToString() == "161") // shift 키 뗐을때
                {
                    ShiftKeyDown = false;
                }

                //return (IntPtr)1;
            }
            else if (code >= 0 && wParam == (IntPtr)WM_ALTDOWN) // ALT 키 눌렀을때
            {
                HotKeyClassification(vkCode, 1);
                //return (IntPtr)1;
                //return CallNextHookEx(hhook, code, (int)wParam, lParam);
            }



            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && (CtrlKeyDown == true || ShiftKeyDown == true))
            {
                if(CtrlKeyDown == true) // ctrl 눌렀을때
                {
                    HotKeyClassification(vkCode, 0);
                }
                else if(ShiftKeyDown == true) // shift 눌렀을때
                {
                    HotKeyClassification(vkCode, 2);
                }
            }

            return CallNextHookEx(hhook, code, (int)wParam, lParam);
            
        }
        
        
        /// <summary>
        /// 단축키 분류
        /// 
        /// option 분류 한 다음
        /// vkcode 분류
        /// 
        /// </summary>
        /// <param name="vkCode">virtualKey</param>
        /// <param name="option">ctrl = 0 , alt = 1, shift = 2 </param>
        /// <returns></returns>
        private static bool HotKeyClassification(int vkCode, int option) 
        {
            
            uint vkCodeMapping;
            char vkCodetoChar;
            string vkCodetoString;

            string KeyChat, KeyMacro1, KeyMacro2, KeyMacro3, KeyMacro4,KeyPTT;
            int KeyChatOption, KeyMacro1Option, KeyMacro2Option, KeyMacro3Option, KeyMacro4Option;

            KeyChat = OptionController.instance.GetHotKeyChat();
            KeyMacro1 = OptionController.instance.GetHotKeyMacro1();
            KeyMacro2 = OptionController.instance.GetHotKeyMacro2();
            KeyMacro3 = OptionController.instance.GetHotKeyMacro3();
            KeyMacro4 = OptionController.instance.GetHotKeyMacro4();
            KeyPTT = OptionController.instance.GetHotKeyPTT();
            KeyChatOption = OptionController.instance.GetHotKeyChatOption();
            KeyMacro1Option = OptionController.instance.GetHotKeyMacro1Option();
            KeyMacro2Option = OptionController.instance.GetHotKeyMacro2Option();
            KeyMacro3Option = OptionController.instance.GetHotKeyMacro3Option();
            KeyMacro4Option = OptionController.instance.GetHotKeyMacro4Option();


            if (vkCode == 32)
            {
                vkCodetoString = "Space";
            }
            else if (vkCode == 13)
            {
                vkCodetoString = "Enter";
            }
            else
            {
                vkCodeMapping = MapVirtualKeyEx((uint)vkCode, 0x02, IntPtr.Zero);
                vkCodetoChar = Convert.ToChar(vkCodeMapping);
                vkCodetoString = vkCodetoChar.ToString();
            }            
            if (option == KeyChatOption && vkCodetoString == KeyChat) // 채팅창
            {
                try
                {
                    chatForm.ShowDialog();
                }
                catch (InvalidOperationException)
                {
                }
            }
            else if(option == KeyMacro1Option && vkCodetoString == KeyMacro1) // 매크로 1
            {
                TTS.ts.PlayMessage("macro0.mp3");
            }
            else if (option == KeyMacro2Option && vkCodetoString == KeyMacro2) // 매크로 2
            {
                TTS.ts.PlayMessage("macro1.mp3");
            }
            else if (option == KeyMacro3Option && vkCodetoString == KeyMacro3) // 매크로 3
            {
                TTS.ts.PlayMessage("macro2.mp3");
            }
            else if (option == KeyMacro4Option && vkCodetoString == KeyMacro4) // 매크로 4
            {
                TTS.ts.PlayMessage("macro3.mp3");
            }


            return false;

        }


        public void setStatus(bool status)
        {
            Console.WriteLine("Status 변화 " + status);
            statusExit = status;
        }


    }
}
