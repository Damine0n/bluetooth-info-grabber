using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRS
{
     static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
         static void Main ()
        {
            MessageBox.Show("Started");
            DateTime now =  DateTime.Now;
            if (new DateTime(now.Year, now.Month, now.Day)>=new DateTime(2013, 12, 31))
            {
                MessageBox.Show("The BETA portion has ended. Thank you for all your help.\n We truly appreciated it.");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainMenu());
            }
            
        }
    }
}
