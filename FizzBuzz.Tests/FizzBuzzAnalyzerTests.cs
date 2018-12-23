using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzAnalyzerTests
    {
        [Fact]
        public void ShouldNotBeNull()
        {
            var analyzer = new Analyzer();

            Assert.NotNull(analyzer);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        public void ShouldReturnTheNumberWhenAnalyzeNotMultiplesOf3And5(int value)
        {
            var analyzer = new Analyzer();
            var expected = value.ToString();

            var actual = analyzer.Analyze(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void ShouldReturnFizzWhenAnalyzeMultiplesOf3(int value)
        {
            var analyzer = new Analyzer();

            var actual = analyzer.Analyze(value);

            Assert.Equal("Fizz", actual);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(100)]
        public void ShouldReturnFizzWhenAnalyzeMultiplesOf5(int value)
        {
            var analyzer = new Analyzer();

            var actual = analyzer.Analyze(value);

            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void ShouldReturnFizzWhenAnalyzeMultiplesOf3And5(int value)
        {
            var analyzer = new Analyzer();

            var actual = analyzer.Analyze(value);

            Assert.Equal("FizzBuzz", actual);
        }
    }
}
