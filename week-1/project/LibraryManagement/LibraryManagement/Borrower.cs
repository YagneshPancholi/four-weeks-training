using System;

public class Borrower
{
    static List<Borrower> borrowers = new List<Borrower>();
    public int BorrowerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Book> borrowedBook { get; set; }
    public static int howManyBorrowers = 0;
    public Borrower(string Name, string email, List<Book> borrowedBook)
    {
        BorrowerId = ++howManyBorrowers;
        Name = Name;
        Email = email;
        borrowedBook = new List<Book>();
    }
    public static void addBorrower()
    {
        Console.WriteLine("Enter Name:");
        string Name = Console.ReadLine();
        
        string Email = "";
        while (Email.Length == 0)
        {
            Console.WriteLine("Enter Email:");
            string tempEmail = Console.ReadLine().Trim();
            if (Utilities.isEmail(tempEmail))
            {
                Email = tempEmail;
            }
        }
        borrowers.Add(new Borrower(Name, Email, new List<Book>()));
    }
    public static bool updateBorrower()
    {
        if(howManyBorrowers == 0)
        {
            Console.WriteLine("There is No Borrower ");
            return false;
        }
        else
        {
            int id = 0;
            bool isIntFlag = false;
            while (!isIntFlag)
            {
                Console.WriteLine("Enter BookID To Update : ");
                string input = Console.ReadLine();
                if (Utilities.isInt(input))
                {
                    id = int.Parse(input);
                    isIntFlag = true;
                }
            }
            var borrower = borrowers.FirstOrDefault(b => b.BorrowerId == id);
            if (borrower != null)
            {
                Console.WriteLine("No Borrower with this ID");
                return false;
            }
            else
            {
                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();

                string Email = "";
                while (Email.Length == 0)
                {
                    Console.WriteLine("Enter Email:");
                    string tempEmail = Console.ReadLine().Trim();
                    if (Utilities.isEmail(tempEmail))
                    {
                        Email = tempEmail;
                    }
                }
                borrower.Name = Name;
                borrower.Email = Email;
                return true;
            }
        }
    }
    public static bool deleteBorrower()
    {
        if (howManyBorrowers == 0)
        {
            Console.WriteLine("There is No Borrower here..");
            return false;
        }
        else
        {
            int id = 0;
            bool isIntFlag = false;
            while (!isIntFlag)
            {
                Console.WriteLine("Enter BookID To Update : ");
                string input = Console.ReadLine();
                if (Utilities.isInt(input))
                {
                    id = int.Parse(input);
                    isIntFlag = true;
                }
            }
            var borrower = borrowers.FirstOrDefault(b =>b.BorrowerId == id);
            if (borrower != null) {
                Console.WriteLine("No Borrower with this ID");
                return false;
            }
            else
            {
                borrowers.Remove(borrower);
                return true;
            }
        }
    }
    public static void listAllBorrowers()
    {
        if(howManyBorrowers == 0)
        {
            Console.WriteLine("There is No Borrower here..");
        }
        else
        {
            foreach(var borrower in borrowers)
            {
                Console.WriteLine("BorrowerId: "+borrower.BorrowerId);
                Console.WriteLine("Name: "+borrower.Name);
                Console.WriteLine("Email: "+borrower.Email);
                if(borrower.borrowedBook == null) {
                Console.WriteLine("BorrowedBooks: 0 ");
                }
                else
                {
                    Console.WriteLine("BorrowedBooks: " + borrower.borrowedBook.Count);
                }
                Console.WriteLine("==========================================");
            }
        }
    }
    public static bool registerBookToBorrower()
    {
        if (Book.HowManyBooksAvaliable == 0 || howManyBorrowers == 0)
        {
            Console.WriteLine("Either There is No book or No Borrower..");
            return false;
        }
        else
        {
            int id = 0;
            bool isIntFlag = false;
            while (!isIntFlag)
            {
                Console.WriteLine("Enter BookID  : ");
                string input = Console.ReadLine();
                if (Utilities.isInt(input))
                {
                    id = int.Parse(input);
                    isIntFlag = true;
                }
            }
            var book = Book.books.FirstOrDefault(b => b.BookId == id && b.NoOfThisBook>0);

            int id1 = 0;
            bool isIntFlag1 = false;
            while (!isIntFlag1)
            {
                Console.WriteLine("Enter BorrowerId : ");
                string input = Console.ReadLine();
                if (Utilities.isInt(input))
                {
                    id1 = int.Parse(input);
                    isIntFlag1 = true;
                }
            }
            var borrwer = borrowers.FirstOrDefault(b =>b.BorrowerId == id1);

            if (book == null || borrwer == null)
            {
                Console.WriteLine("Either No Book or Borrower with THis Id..\n Enter Correct BOth ID..");
                return false;
            }
            else
            {
                if(borrwer.borrowedBook == null)
                {
                    borrwer.borrowedBook  = new List<Book>();
                }
                borrwer.borrowedBook.Add(book);
                book.NoOfThisBook--;
                return true;
            }
        }

    }

    public static void displayBorrowedBooks()
    {
        if (borrowers.Count == 0)
        {
            Console.WriteLine("There is no borrower so no borrowed book");
        }
        else
        {
            int id = 0;
            bool isIntFlag = false;
            while (!isIntFlag)
            {
                Console.WriteLine("Enter BorrowerID : ");
                string input = Console.ReadLine();
                if (Utilities.isInt(input))
                {
                    id = int.Parse(input);
                    isIntFlag = true;
                }
            }
            var borrower = borrowers.FirstOrDefault(b => b.BorrowerId == id);
            if (borrower == null)
            {
                Console.WriteLine("NO Borrower With this ID");
            }

            if (borrower.borrowedBook == null)
            {
                Console.WriteLine("There is no book was borrowed ");
            }
            else
            {
                foreach (var book in borrower.borrowedBook)
                {
                    Console.WriteLine("BookID : " + book.BookId);
                    Console.WriteLine("Title : " + book.Title);
                    Console.WriteLine("Author FullName : " + book.Author.FullName());
                    Console.WriteLine("Publication Year : " + book.PublicationYear);
                    Console.WriteLine("Avaliabe Pieces of this Book: " + book.NoOfThisBook);
                    Console.WriteLine("============================================");
                }
            }
        }
    }
}