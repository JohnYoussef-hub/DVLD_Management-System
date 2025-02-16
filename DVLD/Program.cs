using DVLD_Project.Application;
using DVLD_Project.International_Driving_License;
using DVLD_Project.License.Controls;
using DVLD_Project.Login;
using DVLD_Project.Test_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            //System.Windows.Forms.Application.Run(new frmMain());
            System.Windows.Forms.Application.Run(new frmLogin());
        }
    }
}
