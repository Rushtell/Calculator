using System;
using System.Collections.Generic;
using Xunit;

namespace Calculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalculatorClass()
        {
            double test1 = Calculator.DoOperation(33.33, 11.11, "a");
            double test2 = Calculator.DoOperation(33.33, 11.11, "s");
            double test3 = Calculator.DoOperation(3, 11.11, "m");
            double test4 = Calculator.DoOperation(33.33, 11.11, "d");

            Assert.Equal(44.44, test1);
            Assert.Equal(22.22, test2);
            Assert.Equal(33.33, test3);
            Assert.Equal(3, test4);
            Assert.Throws<InvalidOperationException>(() => Calculator.DoOperation(33.33, 11.11, "none"));
        }

        [Fact]
        public void ShouldReceiveUserInput()
        {
            IConsoleWrapper consoleWrapper = new MockConsoleWrapper();
            string userInput = consoleWrapper.ReadLine();
            string userInput2 = consoleWrapper.ReadLine();
            string userInput3 = consoleWrapper.ReadLine();
            string userInput4 = consoleWrapper.ReadLine();


            Assert.Equal("", userInput);
            Assert.Equal("5", userInput2);
            Assert.Equal("", userInput3);
            Assert.Equal("2", userInput4);
        }

        [Fact]
        public void ShouldMultiplyFiveAndTwo()
        {
            MockConsoleWrapper mockConsoleWrapper = new MockConsoleWrapper();
            Program.StartCalculator(mockConsoleWrapper);

            Assert.Equal("Your result: \n10", mockConsoleWrapper.ConsoleLog[12]);
        }

        [Fact]
        public void TestConsoleWrapper()
        {
            ConsoleWrapper ConsoleWrapper = new ConsoleWrapper();
            ConsoleWrapper.Write("Hello");
            ConsoleWrapper.WriteLine("World!");
        }
    }

    public class MockConsoleWrapper : IConsoleWrapper
    {
        public List<string> ConsoleLog = new List<string>();

        int temp = 0;

        public string ReadLine()
        {
            string[] ArrForTests = new string[]
            {
                "",
                "5",
                "",
                "2",
                "m",
                "",
                "5",
                "2",
                "a",
                "",
                "5",
                "2",
                "s",
                "",
                "5",
                "2",
                "d",
                "",
                "5",
                "0",
                "d",
                "",
                "5",
                "2",
                "p",
                "n"
            };

            temp++;

            return ArrForTests[temp - 1];
        }

        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);

            ConsoleLog.Add($"{msg}");
        }

        public void Write(string msg)
        {
            Console.Write(msg);

            ConsoleLog.Add($"{msg}");
        }
    }
}
