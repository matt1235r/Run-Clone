using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetProcessDPIAware();

            bool handled = false;

            if (args.Count() > 0)
            {
                if (args[0].ToLower() == "-justlaunch")
                {
                    Application.Run(new Run());
                    handled = true;
                }

            }

            if (!handled)
            {
                Application.Run(new Register());
            }

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool SetProcessDPIAware();


    }
}
