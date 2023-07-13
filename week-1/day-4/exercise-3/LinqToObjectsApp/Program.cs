namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Country = "USA" },
                new Person { Name = "Jane", Age = 30, Country = "Canada" },
                new Person { Name = "Mark", Age = 28, Country = "USA" },
                new Person { Name = "Emily", Age = 22, Country = "Australia" }
            };


            //Write queries using LINQ for following operations
            //1. Get all people from USA
            Console.WriteLine("Get all people from USA: ");
            var peoplefromUSA = people.Where(p=>p.Country == "USA");
            foreach(var person in peoplefromUSA)
            {
                Console.Write(person.Name +"\t");
                Console.Write(person.Age);
                Console.WriteLine();
            }
            //2. Get all people above 30
            Console.WriteLine("Get all people above 30: ");
            var above30 = people.Where(p => p.Age >= 30);
            foreach(var person in above30)
            {
                Console.Write(person.Name+"\t");
                Console.Write(person.Age+"\t");
                Console.Write(person.Country);
                Console.WriteLine(); 
            }
            //3. Sort people by name
            Console.WriteLine("Sort people by name: ");    
            var sortedByName = people.OrderBy(p => p.Age);
            foreach(var person in sortedByName)
            {
                Console.Write(person.Name+"\t");
                Console.Write(person.Age+"\t");
                Console.Write(person.Country);
                Console.WriteLine();    
            }
            //4. Project/Select only Name and Country of all people
            Console.WriteLine("Project/Select only Name and Country of all people:");
            //var nameAndCountryOnly = people.Select(p=>p.Name , p.Country).ToList();
            var nameAndCountryOnly = from person in people
                                    select new Person
                                    {
                                        Name = person.Name,
                                        Country = person.Country,
                                    };
            foreach(var person in nameAndCountryOnly)
            {
                Console.Write(person.Name+"\t");
                Console.Write(person.Country);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}