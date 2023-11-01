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

        [Fact]
        public void Should_return_Fizz_when_countOff_given_a_multiple_of_three()
        {
            FizzBuzzGame game = new FizzBuzzGame();
            //given
            int givenNumber = 9;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_countOff_given_a_multiple_of_five()
        {
            FizzBuzzGame game = new FizzBuzzGame();
            //given
            int givenNumber = 10;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);
            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_countOff_given_a_multiple_of_three_and_five()
        {
            FizzBuzzGame game = new FizzBuzzGame();
            //given
            int givenNumber = 15;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);
            //then
            Assert.Equal("FizzBuzz", result);
        }
    }
}