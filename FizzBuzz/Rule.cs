using System.Collections.Generic;

namespace FizzBuzz
{
    public class Rule
    {
        private static Rule FizzRule { get; } = new Rule(3, "Fizz");
        private static Rule BuzzRule { get; } = new Rule(5, "Buzz");

        public static IEnumerable<Rule> GetValues()
        {
            yield return FizzRule;
            yield return BuzzRule;
        }

        public int Value { get; }
        public string Output { get; }
        public Rule(int value, string output)
        {
            this.Value = value;
            this.Output = output;
        }

        public bool Check(int number) => number % Value == 0;
    }
}