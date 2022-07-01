using FluentAssertions;
using TDDKatas.StringCalculator.XUnit;
using Xunit;

namespace TDDKatasXUnitTests {
    public class StringCalculatorTestsKataSeries1 {
        
        [Theory]
        [InlineData("", 0)]
        [InlineData("3",3)]
        [InlineData("1,2,3", 6)]
        [InlineData("1,2,3,4,10,12,15,16,20", 83)]
        public void Add_AddUpToTwoNumbers_WhenStringIsValid(string calculation, int expected) {

            //Arrange
            var sut = new StringCalculatorSeries1();

            //Act
            var result = sut.Add(calculation);

            //Assert
            result.Should().Be(expected);
        }
    }
}