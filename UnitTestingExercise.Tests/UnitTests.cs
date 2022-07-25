using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 0, 5, 7)] //Add test data <-------
        [InlineData(50, 23, 5, 78)] //Add test data <-------
        [InlineData(-20, 15, 5, 0)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calc = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = calc.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]//Add test data <-------
        [InlineData(10,9,1)]//Add test data <-------
        [InlineData(2,10,-8)]//Add test data <-------
        [InlineData(0,10,-10)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,2,10)]//Add test data <-------
        [InlineData(5,5,25)]//Add test data <-------
        [InlineData(4,5,20)]//Add test data <-------
        [InlineData(3,0,0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Multiply(num1, num2);
            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20,5,4)]//Add test data <-------
        [InlineData(0,5,0)]//Add test data <-------
        [InlineData(5,0,0)]//Add test data <-------
        [InlineData(-5,5,-1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}

