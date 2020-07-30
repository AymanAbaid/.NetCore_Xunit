using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Calculator;
namespace TestCalculator
{
    public class TestBasicMath
    {
        [Theory]
        [InlineData(4, 0, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(10, 5, 2)]

        public void DivideNumbers(double a, double b, double expected)
        {

            /// action
            BasicMath cal1 = new BasicMath();
            double actual = cal1.Division(a, b);

            /// assertion
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractNumbers()
        {
            // arrange
            double expected = 2;

            // action
            BasicMath cal1 = new BasicMath();
            double actual = cal1.Subtract(5, 3);

            // assertion
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(4.4, 5.6, 10.0)]
        [InlineData(double.MaxValue, 5.6, double.MaxValue)]
        [InlineData(-4.4, -5.6, -10.0)]
        [InlineData(0, 0, 0)]
        public void AddNumbers(double a, double b, double expected)
        {

            // action
            BasicMath cal1 = new BasicMath();
            double actual = cal1.Add(a, b);

            // assertion
            Assert.Equal(expected, actual);
            //Assert.Eq
        }

        [Fact]
        public void DivideByZero()
        {
            //arrange
            double expected = 0;

            // action
            BasicMath cal1 = new BasicMath();
            double actual = cal1.Division(15, 0);

            // assertion
            Assert.Equal(expected, actual);
        }
    }
}
