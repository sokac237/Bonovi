using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using FastReport.Data;

namespace Bonovi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             Process[] theProcesses = System.Diagnostics.Process.GetProcessesByName(Application.ProductName); //maybe add .exe at the end of Application.ProductName

             if (theProcesses.Length > 1)
             {
                 MessageBox.Show("Ovaj program već je otvoren na ovom računalu!!");

                 Application.Exit();
             }
             else
             {
                 Application.EnableVisualStyles();
                 Application.SetCompatibleTextRenderingDefault(false);
                 FastReport.Utils.RegisteredObjects.AddConnection(typeof(MySqlDataConnection));
                 Application.Run(new frmMain());
             }
        }
    }
}
