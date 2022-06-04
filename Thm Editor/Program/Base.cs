using System;
using System.Windows.Forms;
namespace ThmEditor
{
    public class Flags32
    {
        private uint current_flags = 0;
        public void Add(uint flags, bool set)
        {
            if (set)
                current_flags |= flags;
            else
                current_flags &= ~flags;
        }
        public void Set(uint flags)
        {
            current_flags = flags;
        }
        public uint Get()
        {
            return current_flags;
        }
        public bool Test(uint flag)
        {
            return (current_flags & flag) != 0;
        }
        public void Clear()
        {
            current_flags = 0;
        }

        public Flags32() { }
    }

    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout, MessageBoxIcon icon = 0)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption, 0, icon);
        }
        public static void Show(string text, string caption, int timeout, MessageBoxIcon icon = 0)
        {
            new AutoClosingMessageBox(text, caption, timeout, icon);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}