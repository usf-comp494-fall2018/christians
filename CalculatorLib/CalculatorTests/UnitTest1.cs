using System;
using Xunit;
using CalculatorLib;

namespace CalculatorTests
{
    public class UnitTest1
    {
        //addition tests
        [Fact]
        public void TestAdding4and3()
        {
            //arrange
            double a = 4;
            double b = 3;
            double expected = 7;
            var calc = new Calculator();
            //act
            double actual = calc.Add(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding1and5()
        {
            //arrange
            double a = 1;
            double b = 5;
            double expected = 6;
            var calc = new Calculator();
            //act
            double actual = calc.Add(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

        //subtraction tests
        [Fact]
        public void TestSubtract3from8()
        {
            //arrange
            double a = 8;
            double b = 3;
            double expected = 5;
            var calc = new Calculator();
            //act
            double actual = calc.Subtract(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

        //subtraction tests
        [Fact]
        public void TestSubtract5from12()
        {
            //arrange
            double a = 12;
            double b = 5;
            double expected = 7;
            var calc = new Calculator();
            //act
            double actual = calc.Subtract(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

        //multiplication tests
        [Fact]
        public void TestMultiply3and7()
        {
            //arrange
            double a = 3;
            double b = 7;
            double expected = 21;
            var calc = new Calculator();
            //act
            double actual = calc.Multiply(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiply4and6()
        {
            //arrange
            double a = 4;
            double b = 6;
            double expected = 24;
            var calc = new Calculator();
            //act
            double actual = calc.Multiply(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

        //division tests
        [Fact]
        public void TestDivide27by9()
        {
            //arrange
            double a = 27;
            double b = 9;
            double expected = 3;
            var calc = new Calculator();
            //act
            double actual = calc.Divide(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivide30by5()
        {
            //arrange
            double a = 30;
            double b = 5;
            double expected = 6;
            var calc = new Calculator();
            //act
            double actual = calc.Divide(a, b);
            //assert
            Assert.Equal(expected, actual);
        }

    }

}