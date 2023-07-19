using System;

public class Author
{
    public static List<Author> authors = new List<Author>();
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public static int HowManyAuthors = 0;
    public string FullName() => $"{FirstName}\t{LastName}";
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
        DateOfBirth = DateTime.Now;
    }
    public static void addAuthor()
    {
        Console.WriteLine("Enter Author Details");
        Console.WriteLine("FirstName : ");
        string firstName = Console.ReadLine();
        Console.WriteLine("LastName : ");
        string lastName = Console.ReadLine();
        bool isDOB = false;
        DateTime dob = new DateTime(1901,01,01) ;
        while (!isDOB)
        {
            Console.WriteLine("Enter Date Of Birth(DD-MM-YYYY) or (YYYY-MM-DD) : ");
            string input = Console.ReadLine();
            if (Utilities.isValidateDateOfBirth(input))
            {
                dob = Convert.ToDateTime(input);
                isDOB = true;
            }
        }
        Console.WriteLine(dob);
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
            int id = 0;
            bool isIntFlag = false;
            while (!isIntFlag)
            {
                Console.WriteLine("Enter AuthorID To Update : ");
                string input = Console.ReadLine();
                if (Utilities.isInt(input))
                {
                    id = int.Parse(input);
                    isIntFlag = true;
                }
            }
            var author = authors.FirstOrDefault(a => a.AuthorId == id);
            if (author == null)
            {
                Console.WriteLine("No Author Avaliabe with this ID...");
                return false;
            }else
            {
                Console.WriteLine("Enter Author FirstName : ");
                author.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Author LastName : ");
                author.LastName = Console.ReadLine();
                bool isDOB = false;
                while (!isDOB)
                {
                    Console.WriteLine("Enter Date Of Birth(DD-MM-YYYY) or (YYYY-MM-DD) : ");
                    string input = Console.ReadLine();
                    if (Utilities.isValidateDateOfBirth(input))
                    {
                        author.DateOfBirth = Convert.ToDateTime(input);
                        isDOB = true;
                    }
                }
                return true;
            }
        }
    }
    public static bool deleteAuthor()
    {
        if(HowManyAuthors != 0)
        {
            int id = -1;
            bool isIntFlag = false;
            while (!isIntFlag)
            {
                Console.WriteLine("Enter AuthorId To Delete : ");
                string input = Console.ReadLine();
                if (Utilities.isInt(input))
                {
                    id = int.Parse(input);
                    isIntFlag = true;
                }
            }
            var author = authors.FirstOrDefault(a => a.AuthorId == id);
            if (author == null)
            {
                Console.WriteLine("No Author Avaliable with this ID");
                return false;
            }
            else
            {
                authors.Remove(author);
                Author.HowManyAuthors--;
                return true;
            }
        }
        else
        {
            Console.WriteLine("OOPS, There is NO Author, Please add First..");
            return false;
        }
    }
    public static void listAllAuthors()
    {
        if(HowManyAuthors == 0)
        {
            Console.WriteLine(HowManyAuthors);
            Console.WriteLine("No author is there..");
        }
        else
        {
            foreach (var author in authors)
            {
                Console.WriteLine("AuthorId:" + author.AuthorId);
                Console.WriteLine("Author FullName:" + author.FullName());
                Console.WriteLine("DateOfBirth:" + author.DateOfBirth);
                Console.WriteLine("============================================");
            }
        }
    }
}
