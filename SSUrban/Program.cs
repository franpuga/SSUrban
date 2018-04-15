using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSUrban
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (IsExecutingApplication() == false)
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("S&S Urban Inmobiliaria está ya iniciado.", 
                    "Aplicación ya iniciada", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 
                    MessageBoxDefaultButton.Button2, 
                    MessageBoxOptions.ServiceNotification);
            }
        }

        private static bool IsExecutingApplication()
        {
            // Proceso actual
            Process currentProcess = Process.GetCurrentProcess();

            // Matriz de procesos
            Process[] processes = Process.GetProcesses();

            return processes.Where(p => p.Id != currentProcess.Id && 
                                   p.ProcessName == currentProcess.ProcessName).Any();
        }

    }
}
