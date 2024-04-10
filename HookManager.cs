    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using WinFormsApp1;

    namespace OOTP
    {
        public class HookManager
        {
            public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

            // Виды хуков
            public enum HookType
            {
                WH_KEYBOARD_LL = 13
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct KBDLLHOOKSTRUCT
            {
                public uint vkCode;
                public uint scanCode;
                public uint flags;
                public uint time;
                public IntPtr dwExtraInfo;
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(HookType code, HookProc func, IntPtr hInstance, uint threadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern bool UnhookWindowsHookEx(IntPtr hook);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);

            public static event EventHandler SystemExitButtonClicked;

            private static IntPtr hookId = IntPtr.Zero;
            public static void SetHook()
            {
                hookId = SetWindowsHookEx(HookType.WH_KEYBOARD_LL, HookCallback, GetModuleHandle(null), 0);
            }

            public static void Unhook()
            {
                UnhookWindowsHookEx(hookId);
            }

            private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                // Код клавиши, которая была нажата
                int keyCode = Marshal.ReadInt32(lParam);

                if (nCode >= 0 && (Keys)keyCode == Keys.F4 && Control.ModifierKeys == Keys.Alt)
                {
                    try
                    {
                        File.WriteAllText("log.txt", "Программа завершилась досрочно.\n" +
                                 "Время создания: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка при создании файла: " + ex.Message);
                    }

                    SystemExitButtonClicked?.Invoke(null, EventArgs.Empty);
                }

                // Передаем управление следующему обработчику в цепочке
                return CallNextHookEx(hookId, nCode, wParam, lParam);
            }
        }
    }
