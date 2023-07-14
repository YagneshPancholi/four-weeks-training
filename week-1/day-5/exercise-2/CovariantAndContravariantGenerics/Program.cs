namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    class StringToIntProcessor : IProcessor<string, int>
    {
        // Implement Process method
        public int Process(string input)
        {
           return input.Length;
        }
    }

    class DoubleToStringProcessor : IProcessor<double, string>
    {
        // Implement Process method
        public string Process(double input)
        {
            return input.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Covariance example]
            IProcessor<string,int> stringToIntProcessor = new StringToIntProcessor();
            Console.WriteLine(stringToIntProcessor.Process("Hello World!!"));

            // Contravariance example
            IProcessor<double, string> doubleToStringProcessor = new DoubleToStringProcessor();
            Console.WriteLine(doubleToStringProcessor.Process(2.96));
            Console.ReadLine();
        }
    }
}