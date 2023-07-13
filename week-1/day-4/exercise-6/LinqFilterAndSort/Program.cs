namespace LinqFilterAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Create a list of Person objects
        List<Person> people = new List<Person>
            {
               new Person {firstName="Cook", lastName="Tim", age=35},
               new Person {firstName="Candel", lastName="Jenner", age=30},
               new Person {firstName="Hardy", lastName="Sandhu", age=17},
               new Person {firstName="Sandeep", lastName="Sharma", age=54},
               new Person {firstName="Bill", lastName="Gates", age=61},
               new Person {firstName="Michal", lastName="Clark", age=41},
               new Person {firstName="Mukesh", lastName="Pyare", age=5},
               new Person {firstName="Neeta", lastName="Sheth", age=12},
               new Person {firstName="Jagdish", lastName="Patel", age=22},
               new Person {firstName="Svami", lastName="Patel", age=18},
            };
            //people who are 18 years old or older
            Console.WriteLine("people who are 18 years old or older: ");
            var adultPeople = people.Where(p => (p.age >= 18));
            Console.WriteLine("FirstName"+"\t"+"LastName"+"\t"+"Age");
            foreach (Person person in adultPeople)
            {
                Console.WriteLine(person.firstName + "\t\t" + person.lastName+"\t\t"+person.age);
            }
            //  sort the filtered list by last name, then by first name
            Console.WriteLine("sort the filtered list by last name, then by first name: ");
            var sortedByLastNameThenFirstName = adultPeople.OrderBy(p => p.firstName).OrderBy(p=>p.lastName);
            Console.WriteLine("FirstName" + "\t" + "LastName" + "\t" + "Age");
            foreach (Person person in sortedByLastNameThenFirstName)
            {
                Console.WriteLine(person.firstName + "\t\t" + person.lastName+"\t\t"+person.age);
            }

            Console.ReadLine();
        }
    }
    public class Person
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public int age { get; set; }
    }
}