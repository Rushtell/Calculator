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
    }
}
