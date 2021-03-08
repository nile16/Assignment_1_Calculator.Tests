using System;
using Xunit;


namespace Assignment_1_Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Test_Addition_Doubles()
        {
            Assert.Equal("The sum of 2 and 3 is: 5", Calculator.Addition(2, 3));
            Assert.Equal("The sum of 2 and -3 is: -1", Calculator.Addition(2, -3));
        }

        [Fact]
        public void Test_Addition_Array()
        {
            Assert.Equal("The sum of 2, 3, 4 is: 9", Calculator.Addition(new double[] { 2, 3, 4 }));
            Assert.Equal("The array must contain at least two elements.", Calculator.Addition(new double[] { 2 }));
            Assert.Equal("The array must contain at least two elements.", Calculator.Addition(new double[] { }));
        }

        [Fact]
        public void Test_Subtraction_Doubles()
        {
            Assert.Equal("The difference of 5 and 3 is: 2", Calculator.Subtraction(5, 3));
            Assert.Equal("The difference of 3 and 5 is: -2", Calculator.Subtraction(3, 5));
        }

        [Fact]
        public void Test_Subtraction_Array()
        {
            Assert.Equal("The difference of 2, 2, 7, 9, 5 is: -21", Calculator.Subtraction(new double[] { 2, 2, 7, 9, 5 }));
            Assert.Equal("The array must contain at least two elements.", Calculator.Subtraction(new double[] { 2 }));
            Assert.Equal("The array must contain at least two elements.", Calculator.Subtraction(new double[] { }));
        }

        [Fact]
        public void Test_Division()
        {
            Assert.Equal("The quotient of 8 and 2 is: 4", Calculator.Division(8, 2));
            Assert.Equal("The quotient of 2 and -4 is: -0,5", Calculator.Division(2, -4));
            Assert.Equal("Division by zero is not allowed.", Calculator.Division(2, 0));
        }

        [Fact]
        public void Test_Multiplication()
        {
            Assert.Equal("The product of 5 and 4 is: 20", Calculator.Multiplication(5, 4));
            Assert.Equal("The product of -0,5 and 4 is: -2", Calculator.Multiplication(-0.5, 4));
        }

        [Theory]
        [InlineData(2, 3, "The exponentiation of 2 and 3 is: 8")]
        [InlineData(-2, 2, "The exponentiation of -2 and 2 is: 4")]
        [InlineData(-2, 3, "The exponentiation of -2 and 3 is: -8")]
        [InlineData(9, 0.5, "The exponentiation of 9 and 0,5 is: 3")]
        public void Test_Exponentiation(double bas, double exponent, string expected)
        {
            Assert.Equal(expected, Calculator.Exponentiation(bas, exponent));
        }

        [Theory]
        [InlineData(27, 3, "The 3 root of 27 is: 3")]
        [InlineData(9, 0.5, "The 0,5 root of 9 is: 81")]
        public void Test_Radical(double radicand, double index, string result)
        {
            Assert.Equal(result, Calculator.Radical(radicand, index)); 
        }
    }
}
