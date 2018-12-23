using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzAnalyzerTests
    {
        public static IEnumerable<object[]> OnlyMultiplesOf3 => from number in Enumerable.Range(1, 100)
                                                                where number % 3 == 0 && number % 5 != 0
                                                                select new object[] { number };
        public static IEnumerable<object[]> OnlyMultiplesOf5 => from number in Enumerable.Range(1, 100)
                                                                where number % 3 != 0 && number % 5 == 0
                                                                select new object[] { number };

        public static IEnumerable<object[]> MultiplesOf3And5 => from number in Enumerable.Range(1, 100)
                                                                where number % 3 == 0 && number % 5 == 0
                                                                select new object[] { number };
        public static IEnumerable<object[]> NotMultiplesOf3And5 => from number in Enumerable.Range(1, 100)
                                                                   where number % 3 != 0 && number % 5 != 0
                                                                   select new object[] { number };

        [Fact]
        public void ShouldNotBeNull()
        {
            var analyzer = new Analyzer();

            Assert.NotNull(analyzer);
        }

        [Theory]
        [MemberData(nameof(NotMultiplesOf3And5))]
        public void ShouldReturnTheNumberWhenAnalyzeNotMultiplesOf3And5(int number)
        {
            var analyzer = new Analyzer();
            var expected = number.ToString();

            var actual = analyzer.Analyze(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(OnlyMultiplesOf3))]
        public void ShouldReturnFizzWhenAnalyzeMultiplesOf3(int number)
        {
            var analyzer = new Analyzer();

            var actual = analyzer.Analyze(number);

            Assert.Equal("Fizz", actual);
        }

        [Theory]
        [MemberData(nameof(OnlyMultiplesOf5))]
        public void ShouldReturnFizzWhenAnalyzeMultiplesOf5(int number)
        {
            var analyzer = new Analyzer();

            var actual = analyzer.Analyze(number);

            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [MemberData(nameof(MultiplesOf3And5))]
        public void ShouldReturnFizzWhenAnalyzeMultiplesOf3And5(int number)
        {
            var analyzer = new Analyzer();

            var actual = analyzer.Analyze(number);

            Assert.Equal("FizzBuzz", actual);
        }
    }
}
