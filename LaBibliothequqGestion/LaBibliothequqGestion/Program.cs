using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaBibliothequqGestion
{
    static class Program
    {
        public static long Id;
        public static bool IsAdmin;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Security.LogIn());
            Application.Run(new ProgramMain());
        }
    }
}
