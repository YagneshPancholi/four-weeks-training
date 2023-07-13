namespace LinqListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            // Use LINQ to perform the following operations:

            // 1. Find all even numbers
            Console.WriteLine("even numbers:");
            var evenNumbers = numbers.Where(n => n % 2== 0);
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // 2. Find all numbers greater than a specific value (e.g., 20)
            Console.WriteLine("Numbers greater than 20: ");
            var numbersGreatedThan20 = numbers.Where(n => n>20);
            foreach (var number in numbersGreatedThan20)
            {
                Console.WriteLine(number);
            }

            // 3. Calculate the sum of all numbers
            Console.WriteLine("Sum of all numbers: ");
            int sumOfAllNumbers = numbers.Sum(n => n);
            Console.WriteLine(sumOfAllNumbers);
            
            // 4. Calculate the average of all numbers
            Console.WriteLine("average of all numbers:");
            Console.WriteLine(sumOfAllNumbers/(double)numbers.Count);

            // 5. Find the minimum and maximum values in the list
            var minNumber = numbers.Min(n => n);
            var maxNumber = numbers.Max(n => n);
            Console.WriteLine("minNumber: "+minNumber+"\n"+"maxNumber: "+maxNumber);

            // 6. Find all odd numbers
            Console.WriteLine("Odd numbers:");
            var oddNumbers = numbers.Where(n => n % 2 != 0);
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}