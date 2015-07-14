using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sistemaBufetes
{
    static class Program
    {
        public static dal.DT dt;
        public static forms.Main main;        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loader());            
           
        }
    }
}
