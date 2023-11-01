using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_the_number_when_countOff_given_a_normal_case_number()
        {
            FizzBuzzGame game = new FizzBuzzGame();
            //given
            int givenNumber = 1;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber); //press generate to create CountOff() in FizzBuzzGame.cs
            //then
            Assert.Equal("1", result);
        }
    }
}