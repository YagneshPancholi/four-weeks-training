namespace IteratorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = FibonacciSequence().Take(10);
            foreach (int number in fibonacci)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
        // https://www.c-sharpcorner.com/UploadFile/5ef30d/understanding-yield-return-in-C-Sharp/
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield
        public static IEnumerable<int> FibonacciSequence()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            for(int i = 2; i < 20; i++)
            {
                list.Add(list.ElementAt(i-1) + list.ElementAt(i-2));
            }
            foreach (int number in list)
            {
                yield return number;
            }
        }
    }
}