namespace FizzBuzz
{
    public class Analyzer
    {
        public Analyzer()
        {
        }

        public string Analyze(int value)
        {
            if (value == 3)
            {
                return "Fizz";
            }
            else if (value == 5)
            {
                return "Buzz";
            }

            return value.ToString();
        }
    }
}