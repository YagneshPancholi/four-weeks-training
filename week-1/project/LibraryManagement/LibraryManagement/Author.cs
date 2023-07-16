using System;

public class Author
{
    static List<Author> authors = new List<Author>();
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public static int HowManyAuthors = 0;
    public string fullName() => $"{FirstName}\t{LastName}";
    public Author(string firstName, string lastName, DateTime dob)
    {
        AuthorId = ++HowManyAuthors;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }
    public Author(string firstName, string lastName)
    {
        AuthorId = ++HowManyAuthors;
        FirstName = firstName;
        LastName = lastName;
    }
    public static void addAuthor()
    {
        Console.WriteLine("Enter Author Details");
        Console.WriteLine("FirstName : ");
        string firstName = Console.ReadLine();
        Console.WriteLine("LastName : ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Date Of Birst(YYYY-MM-DD) : ");
        DateTime dob = Convert.ToDateTime(Console.ReadLine());
        authors.Add(new Author(firstName, lastName, dob));
    }
    public static bool updateAuthor()
    {
        if (Author.HowManyAuthors == 0)
        {
            Console.WriteLine("There is no author avaliable...");
            return false;
        }
        else
        {
            Console.WriteLine("Enter AuthorID To Update : ");
            return true;
        }
    }
    public static bool deleteAuthor()
    {
        return false;
    }
    public static void listAllAuthors()
    {
    }
}
