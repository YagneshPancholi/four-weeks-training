using System.Text.RegularExpressions;

public class Utilities
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Library Management System!\n");
        Console.WriteLine("1. Add a book");
        Console.WriteLine("2. Update a book");
        Console.WriteLine("3. Delete a book");
        Console.WriteLine("4. List all books");
        Console.WriteLine("5. Add an author");
        Console.WriteLine("6. Update an author");
        Console.WriteLine("7. Delete an author");
        Console.WriteLine("8. List all authors");
        Console.WriteLine("9. Add a borrower");
        Console.WriteLine("10. Update a borrower");
        Console.WriteLine("11. Delete a borrower");
        Console.WriteLine("12. List all borrowers");
        Console.WriteLine("13. Register a book to a borrower");
        Console.WriteLine("14. Display borrowed book");
        Console.WriteLine("15. Search books");
        Console.WriteLine("16. Filter books by status");
        Console.WriteLine("17. Exit");
        Console.WriteLine("\nEnter the number corresponding to the action you'd like to perform:");
    }
    public static void showSuccessMessage(string message)
    {
        Console.WriteLine(message + " Successfully...");
    }
    public static void showUnsuccessMessage(String message)
    {
        Console.WriteLine(message + " Unsuccessfull!!!");
    }
    public static bool isInt(string input)
    {
        int ignoreMe = 0;
        if (int.TryParse(input, out ignoreMe))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Please enter only Integer Value...");
            return false;
        }

    }
    public static bool isPublicationFormate(string input)
    {
        if (isInt(input) && input.Length == 4)
        {
            return true;
        }
        Console.WriteLine("Wrong Format !!!\nPublicationYear format should be YYYY, eg.2001, 1998 etc .");
        return false;
    }
    public static bool isValidateDateOfBirth(string input)
    {
        if(DateTime.TryParse(input, out DateTime ignoreMe))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Wrong Date Format, Please Follow This Formate(DD-MM-YYYY) or (YYYY-MM-DD)");
            return false;
        }
    }
    public static bool isEmail(string input)
    {
        Regex pattern = new Regex(@"^([a-zA-Z0-9])*@([a-zA-Z]*)\.(([a-zA-Z]{2}\.[a-zA-Z]{2})|([A-Za-z]{2,3}))$");
        if(pattern.IsMatch(input))
        {
            return true;
        }
        return false;
    }
}
