using TDDKatas.StringCalculator.XUnit;
using Xunit;

namespace TDDKatasXUnitTests {
    public class StringCalculatorTestsKataSeries1 {
        
        [Theory]
        [InlineData("3",0)]
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