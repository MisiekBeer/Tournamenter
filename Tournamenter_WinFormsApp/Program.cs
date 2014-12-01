using Logic;
using System;
using System.Windows.Forms;

namespace Tournamenter_WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PlayerList.Instance.LoadPlayerList();

            Application.Run(new MainForm());

            PlayerList.Instance.Dispose();
            Speaker.Instance.KillAll();
        }
    }
}