namespace FizzBuzz
{
    public class Rule
    {
        public int Value { get; }
        public string Output { get; }
        public Rule(int value, string output)
        {
            this.Value = value;
            this.Output = output;
        }
    }
}