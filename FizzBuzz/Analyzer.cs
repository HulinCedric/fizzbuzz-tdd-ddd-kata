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
            if (number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number % 5 == 0)
            {
                result += "Buzz";
            }
            return result ?? number.ToString();
        }
    }
}