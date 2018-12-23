using System.Collections.Generic;

namespace FizzBuzz
{
    public class Analyzer
    {
        public Analyzer()
        {
        }

        public string Analyze(int number)
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
    }
}