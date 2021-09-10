using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartInMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model()
            {
                Monitor = int.Parse(args[0]),
                Application = args[1],
                Arguments = args[2],
                Left = int.Parse(args[3]),
                Top = int.Parse(args[4]),
                Width = int.Parse(args[5]),
                Height = int.Parse(args[6]),
            };

            Start(model);
        }

        public static void Start(Model model)
        {
            var allScreens = Screen.AllScreens.ToList();

            var screenOfChoice = allScreens.First();
            if (allScreens.Count >= model.Monitor)
            {
                screenOfChoice = allScreens[(model.Monitor - 1)];
            }

            var process = new Process
            {
                StartInfo =
                {
                    Arguments = model.Arguments,
                    FileName = model.Application,
                    WindowStyle = ProcessWindowStyle.Normal
                }
            };

            process.Start();

            Thread.Sleep(1000);

            MoveWindow(process.MainWindowHandle, (screenOfChoice.WorkingArea.Left + model.Left), (screenOfChoice.WorkingArea.Top + model.Top), (screenOfChoice.WorkingArea.Width - model.Width), (screenOfChoice.WorkingArea.Height - model.Height), false);
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
    }
}
