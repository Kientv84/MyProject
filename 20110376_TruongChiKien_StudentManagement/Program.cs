using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            loginform flogin = new loginform();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else { Application.Exit(); }
        }
    }
}
