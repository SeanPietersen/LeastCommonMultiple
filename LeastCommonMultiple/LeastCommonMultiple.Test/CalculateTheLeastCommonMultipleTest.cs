using LeastCommonMultiple.App;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeastCommonMultiple.Test
{
    public class CalculateTheLeastCommonMultipleTest
    {
        [Fact]
        public void LowestCommonMultipleCalculatorTest1()
        {
            //Arrange
            ICalculateTheLeastCommonMultiple calculateTheLeastCommonMultiple = new CalculateTheLeastCommonMultiple();
            var list = new List<int> { 2, 5 };
            var expected = 10;

            //Act
            var actual = calculateTheLeastCommonMultiple.LowestCommonMultiple(list);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LowestCommonMultipleCalculatorTest2()
        {
            //Arrange
            ICalculateTheLeastCommonMultiple calculateTheLeastCommonMultiple = new CalculateTheLeastCommonMultiple();
            var list = new List<int> { 2, 3, 4 };
            var expected = 12;

            //Act
            var actual = calculateTheLeastCommonMultiple.LowestCommonMultiple(list);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LowestCommonMultipleCalculatorTest3()
        {
            //Arrange
            ICalculateTheLeastCommonMultiple calculateTheLeastCommonMultiple = new CalculateTheLeastCommonMultiple();
            var list = new List<int> { 9};
            var expected = 9;

            //Act
            var actual = calculateTheLeastCommonMultiple.LowestCommonMultiple(list);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
