using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Thanks http://stackoverflow.com/questions/6786891/wndproc-how-to-get-window-messages-when-form-is-minimized

namespace GeDoSaToTool
{
    class MessageWindow : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        MainForm form;

        public MessageWindow(MainForm form)
        {
            var accessHandle = this.Handle;
            this.form = form;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ChangeToMessageOnlyWindow();
        }

        private void ChangeToMessageOnlyWindow()
        {
            IntPtr HWND_MESSAGE = new IntPtr(-3);
            SetParent(this.Handle, HWND_MESSAGE);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Native.WM_SHOWME)
            {
                form.ShowMe();
                Close();
            }
            base.WndProc(ref m);
        }
    }
}
