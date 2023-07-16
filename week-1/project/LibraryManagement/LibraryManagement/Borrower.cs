using System;

public class Borrower
{
    static List<Borrower> borrowers = new List<Borrower>();
    public int BorrowerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public static int howManyBorrowers = 0;
    public Borrower(string firstName, string lastName, string email, string phoneNumber)
    {
        BorrowerId = ++howManyBorrowers;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }
    public static void addBorrower()
    {

    }
    public static void updateBorrower()
    {

    }
    public static void deleteBorrower()
    {

    }
    public static void listAllBorrowers()
    {

    }
    public static void registerBookToBorrower()
    {

    }
}