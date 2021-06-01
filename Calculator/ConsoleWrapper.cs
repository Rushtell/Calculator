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

        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Write(string msg)
        {
            Console.Write(msg);
        }
    }
}
