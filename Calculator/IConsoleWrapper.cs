using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IConsoleWrapper
    {
        string ReadLine();

        void WriteLine(string msg);

        void Write(string msg);
    }
}
