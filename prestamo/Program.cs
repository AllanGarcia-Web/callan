using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perloan_Desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada a la aplicación.
        /// </summary>
        static Mutex mutex = new Mutex(false, Application.ProductName);
        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(0), false))
            {
                MessageBox.Show(Application.ProductName+ " ya esta esta en ejecuión!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmSplash());
            }
            finally { mutex.ReleaseMutex(); }
        }
    }
}