using AnimalExercise;
namespace AnimalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Animal objects, add Dog and Cat instances, and call their methods
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Dog1",5),
                new Cat("Cat1",4)
            };
            Console.WriteLine(animals.ElementAt(0).name);
            Console.WriteLine(animals.ElementAt(0).age);
            animals.ElementAt(0).makeSound();
            ((Dog)animals.ElementAt(0)).move();
            Console.WriteLine(animals.ElementAt(1).name);
            Console.WriteLine(animals.ElementAt(1).age);
            animals.ElementAt(1).makeSound();
            ((Cat)animals.ElementAt(1)).move();

            //Console.WriteLine(animals.GetType());
            Console.ReadLine();
           
        }
    }
}