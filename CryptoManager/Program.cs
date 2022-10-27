using System;
using System.Windows.Forms;

namespace CryptoManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware(); // Исправление замыленности на масштабированных мониторах

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CryptoManager());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware(); // Исправление замыленности на масштабированных мониторах
    }
}
