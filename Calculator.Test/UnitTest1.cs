using System;
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
            double test5 = Calculator.DoOperation(33.33, 11.11, "none");

            Assert.Equal(44.44, test1);
            Assert.Equal(22.22, test2);
            Assert.Equal(33.33, test3);
            Assert.Equal(3, test4);
            Assert.Equal(double.NaN, test5);
        }

        [Fact]
        public void ShouldReceiveUserInput()
        {
            IConsoleWrapper consoleWrapper = new MockConsoleWrapper();
            string userInput = consoleWrapper.ReadLine();
            string userInput2 = consoleWrapper.ReadLine();
            string userInput3 = consoleWrapper.ReadLine();
            string userInput4 = consoleWrapper.ReadLine();

            Assert.Equal("5", userInput);
            Assert.Equal("2", userInput2);
            Assert.Equal("m", userInput3);
            Assert.Equal("n", userInput4);
        }

        [Fact]
        public void ShouldMultiplyFiveAndTwo()
        {
            MockConsoleWrapper mockConsoleWrapper = new MockConsoleWrapper();
            Program.StartCalculator(mockConsoleWrapper);
        }

    }

    public class MockConsoleWrapper : IConsoleWrapper
    {
        int temp = 0;

        public string ReadLine()
        {
            string[] ArrForTests = new string[]
            {
                "5",
                "2",
                "m",
                "n"
            };

            temp++;

            return ArrForTests[temp - 1];

        }
    }
}
