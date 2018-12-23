namespace FizzBuzz
{
    public class Analyzer
    {
        public Analyzer()
        {
        }

        public string Analyze(int value)
        {
            if (value % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }

            return value.ToString();
        }
    }
}