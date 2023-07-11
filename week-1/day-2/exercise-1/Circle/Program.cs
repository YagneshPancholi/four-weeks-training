namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle object and display its area and circumference
            Circle c1 = new Circle(1.0);
            Console.WriteLine("Ares : "+ c1.getArea());
            Console.WriteLine("Circumference : "+c1.getCircumference());
            Console.ReadLine();
        }
    }
}