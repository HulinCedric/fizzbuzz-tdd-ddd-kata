using System.Collections.Generic;

namespace FizzBuzz
{
    public class Rule
    {
        private static Rule FizzRule { get; } = new Rule(3, "Fizz");
        private static Rule BuzzRule { get; } = new Rule(5, "Buzz");

        private static IEnumerable<Rule> GetValues()
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

        public static string Analyze(int number)
        {
            var result = default(string);
            foreach (var rule in Rule.GetValues())
            {
                if (rule.Check(number))
                {
                    result += rule.Output;
                }
            }

            return result ?? number.ToString();
        }

        private bool Check(int number) => number % Value == 0;
    }
}