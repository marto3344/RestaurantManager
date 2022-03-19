using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestаurantManager.Controller;
namespace RestаurantManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StartUp startUp = new StartUp();
            startUp.StartApplication();
        }
    }
}
