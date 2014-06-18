using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeDoSaToTool
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{A9A841C4-9B1A-4EA2-A174-01E2B8038BB3}");
        [STAThread]
        static void Main(string[] args)
        {
            if(mutex.WaitOne(TimeSpan.Zero, true)) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                bool autoActivate = !args.Contains("-a");
                Application.Run(new MainForm(autoActivate));
                mutex.ReleaseMutex();
            } else {
                // send our Win32 message to make the currently running instance
                // jump on top of all the other windows
                Native.PostMessage(
                    (IntPtr)Native.HWND_BROADCAST,
                    Native.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
        }
    }
}
