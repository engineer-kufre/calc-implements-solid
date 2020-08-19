using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create the connection between the UI and the library
            DISocket.PlugSocket();
            ICalcOperations operations = DISocket.Isocket;
            Application.Run(new CalcuatorForm(operations));
        }
    }
}
