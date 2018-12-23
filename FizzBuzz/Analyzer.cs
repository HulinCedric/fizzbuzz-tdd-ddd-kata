using System.Collections.Generic;

namespace FizzBuzz
{
    public class Analyzer
    {
        private IEnumerable<Rule> rules => new List<Rule> {
            new Rule(3, "Fizz"),
            new Rule(5, "Buzz")
        };

        public Analyzer()
        {
        }

        public string Analyze(int number)
        {
            var result = default(string);
            foreach (var rule in rules)
            {
                if (number % rule.Value == 0)
                {
                    result += rule.Output;
                }
            }
            
            return result ?? number.ToString();
        }
    }
}