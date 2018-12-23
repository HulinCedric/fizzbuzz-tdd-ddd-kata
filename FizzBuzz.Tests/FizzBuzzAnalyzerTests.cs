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
    }
}
