using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    //Dependency Injection occurs in this class
    public static class DISocket
    {
        public static ICalcOperations Isocket { get; set; }

        //connects the UI to the library by matching a plug instance to the interface socket
        public static void PlugSocket()
        {
            CalcOperations plug = new CalcOperations();
            Isocket = plug;
        }
    }
}
