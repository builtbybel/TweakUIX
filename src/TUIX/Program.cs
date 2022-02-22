using System;
using System.Windows.Forms;

namespace TweakUIX
{
    internal static class Program
    {
        /// <summary>
        /// Gets App version
        /// </summary>
        internal static string GetCurrentVersionTostring() => new Version(Application.ProductVersion).ToString(4);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}