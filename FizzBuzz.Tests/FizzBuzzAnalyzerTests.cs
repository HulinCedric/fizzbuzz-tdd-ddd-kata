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
    }
}
