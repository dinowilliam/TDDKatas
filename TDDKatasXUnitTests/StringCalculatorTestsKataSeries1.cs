using FluentAssertions;
using TDDKatas.StringCalculator.XUnit;
using Xunit;

namespace TDDKatasXUnitTests {
    public class StringCalculatorTestsKataSeries1 {

        [Theory]
        [InlineData("", 0)]
        [InlineData("3", 3)]
        [InlineData("5", 5)]
        [InlineData("3,5", 8)]
        [InlineData("5,5", 10)]
        [InlineData("5,7", 12)]

        public void Add_AddUpToTwoNumbers_WhenStringIsValid(string calculation, int expected) {

            //Arrange
            var sut = new StringCalculatorSeries1();

            //Act
            var result = sut.Add(calculation);

            //Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("1,2,3,4", 10)]
        [InlineData("1,2,3,4,5", 15)]
        [InlineData("1,2,3,4,10,12,15,16,20", 83)]
        public void Add_AddUpToAnyNumbers_WhenStringIsValid(string calculation, int expected) {
            //Arrange
            var sut = new StringCalculatorSeries1();

            //Act
            var result = sut.Add(calculation);

            //Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("3", 3)]
        [InlineData("1\n2,3", 6)]
        [InlineData("10\n20,30\n40,50", 150)]
        public void Add_AddNumbersUsingNewLineDelimiter_WhenStringIsValid(string calculation, int expected) {
            //Arrange
            var sut = new StringCalculatorSeries1();

            //Act
            var result = sut.Add(calculation);

            //Assert
            result.Should().Be(expected);
        }
    }
}