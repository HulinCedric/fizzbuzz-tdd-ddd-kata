using System.Collections.Generic;
using System.Text;

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
            var result = new StringBuilder();
            foreach (var rule in Rule.GetValues())
            {
                result.Append(rule.Check(number));
            }

            if (result.Length == 0)
            {
                result.Append(number);
            }

            return result.ToString();
        }

        private string Check(int number) => number % Value == 0 ? Output : default(string);
    }
}