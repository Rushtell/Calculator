using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
