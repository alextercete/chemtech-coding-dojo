using Xunit;

namespace CodingDojo
{
    public class TestFizzBuzzCalculator
    {
        [Fact]
        public void TestNumberOne()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            Assert.Equal("1", fizzBuzzCalculator.Calculate(1));
        }

        [Fact]
        public void TestNumberTwo()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            Assert.Equal("2", fizzBuzzCalculator.Calculate(2));
        }

        [Fact]
        public void TestNumberThree()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            Assert.Equal("FIZZ", fizzBuzzCalculator.Calculate(3));
        }

        [Fact]
        public void TestNumberFive()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            Assert.Equal("BUZZ", fizzBuzzCalculator.Calculate(5));
        }

        [Fact]
        public void TestNumberSix()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            Assert.Equal("FIZZ", fizzBuzzCalculator.Calculate(6));
        }

        [Fact]
        public void TestNumberTen()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            Assert.Equal("BUZZ", fizzBuzzCalculator.Calculate(10));
        }

        [Fact]
        public void TestNumberFifteen()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            Assert.Equal("FIZZBUZZ", fizzBuzzCalculator.Calculate(15));
        }
    }
}
