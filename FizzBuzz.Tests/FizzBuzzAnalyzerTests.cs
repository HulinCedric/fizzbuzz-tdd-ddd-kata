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

        [Fact]
        public void ShouldReturn1WhenAnalyze1()
        {
            var analyzer = new Analyzer();

            var result = analyzer.Analyze(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void ShouldReturnBuzzWhenAnalyze100()
        {
            var analyzer = new Analyzer();

            var result = analyzer.Analyze(100);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ShouldReturnFizzWhenAnalyze3()
        {
            var analyzer = new Analyzer();

            var result = analyzer.Analyze(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ShouldReturnBuzzWhenAnalyze5()
        {
            var analyzer = new Analyzer();

            var result = analyzer.Analyze(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ShouldReturnFizzWhenAnalyze6()
        {
            var analyzer = new Analyzer();

            var result = analyzer.Analyze(6);

            Assert.Equal("Fizz", result);
        }
    }
}
