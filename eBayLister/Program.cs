using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eBayLister
{
    public delegate void dChangeStatus(string status);
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static frmMain mainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new frmMain();
            Application.Run(mainForm);
        }


    }
}
