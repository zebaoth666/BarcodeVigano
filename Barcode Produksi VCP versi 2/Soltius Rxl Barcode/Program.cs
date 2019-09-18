using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Soltius.RetailExcel.Utils.PrintBarcode {

    [DebuggerNonUserCode]
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                bool newInstance = true;
                Mutex singleAppMutex = new Mutex(true, ApplicationInfo.AbbreviatedApplicationName, out newInstance);
                if (!newInstance) {
                    MessageBox.Show("Application already running.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                GC.KeepAlive(singleAppMutex);
                try {
                    Application.Run(new frmLogin());
                } catch {
                    //throw;
                }
                singleAppMutex.Close();
            } catch {
                throw;
            }
        }
    }

}
