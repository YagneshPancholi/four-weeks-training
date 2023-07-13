namespace FactorialApp
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is: {factorial}");
            Console.ReadLine();
        }

        public static long CalculateFactorial(int number)
        {
            if( number == 0)
            {
                return 1;
            }

            try
            {
                if (number < 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}