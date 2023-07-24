namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle object and display its area and circumference
            Circle c1 = new(1.0);
            Console.WriteLine("Ares : "+ c1.GetArea());
            Console.WriteLine("Circumference : " + c1.GetCircumference());
            Console.ReadLine();
        }
    }
}