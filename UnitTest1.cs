using System;
using Xunit;


namespace Assignment_1_Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Addition()
        {
            Assert.Equal("The sum of 2 and 3 is: 5", Calculator.Addition(2, 3));
        }

        [Fact]
        public void Test_Subtraction()
        {
            Assert.Equal("The difference of 5 and 3 is: 2", Calculator.Subtraction(5, 3));
        }
        [Fact]
        public void Test_Division()
        {
            Assert.Equal("The quotient of 8 and 2 is: 4", Calculator.Division(8, 2));
        }
        [Fact]
        public void Test_Multiplication()
        {
            Assert.Equal("The product of 5 and 4 is: 20", Calculator.Multiplication(5, 4));
        }
        [Fact]
        public void Test_Exponentiation()
        {
            Assert.Equal("The exponentiation of 2 and 3 is: 8", Calculator.Exponentiation(2, 3));
        }
        [Fact]
        public void Test_Radical()
        {
            Assert.Equal("The 3 root of 27 is: 3", Calculator.Radical(27, 3));
        }
    }
}
