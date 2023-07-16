using System.Diagnostics;

namespace LibraryManagement
{
    internal class Program
    {

        static List<Book> books = new List<Book>();
        static List<Author> authors = new List<Author>();
        static List<Borrower> borrowers = new List<Borrower>();
        static List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                DisplayMenu();

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        addBook();
                        showSuccessMessage("Book Added");
                        break;
                     case 2:
                        if (updateBook())
                        {
                            showSuccessMessage("Book Updated");
                        }
                        else
                        {
                            showUnsuccessMessage("Book Updated");
                        }
                        break;  
                     case 3:
                        if (deleteBook())
                        {
                            showSuccessMessage("Book Deleted");
                        }
                        else
                        {
                            showUnsuccessMessage("Book Deleted");
                        }
                        break;
                     case 4:
                        listAllBooks();                            
                        break;
                     case 5:
                        addAuthor();
                        showSuccessMessage("Author Added");
                        break;
                     case 6:
                        updateAuthor();
                        break;
                     case 7:
                        deleteAuthor();
                         break;
                     case 8:
                        listAllAuthors();
                        break;
                     case 9:
                        addBorrower();
                         break;
                     case 10:
                        updateBorrower();
                         break;
                     case 11:
                        deleteBorrower();
                         break;
                     case 12:
                        listAllBorrowers();
                         break;
                     case 13:
                        registerBookToBorrower();
                         break;
                     case 14:
                        displayBorrowedBooks();
                         break;
                     case 15:
                        searchBooks();
                         break;
                    case 16:
                        filterBooksByStatus();
                        break;
                    case 17:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            Console.WriteLine("_____Thank You_____");
            Console.ReadLine();
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
            return int.TryParse(input, out ignoreMe);

        }
        public static bool isPublicationFormate(string input) 
        {
            if(isInt(input) && input.Length == 4)
            {
                return true;
            }
            Console.WriteLine("Wrong Format !!!\nPublicationYear format should be YYYY, eg.2001, 1998 etc .");
            return false;
        }
        public static void addBook()
        {
            Console.WriteLine("Enter Book Details");
            Console.WriteLine("Title : ");
            string? title = Console.ReadLine();
            Console.WriteLine("Publication Year : ");
            int publicationYear = 0;
            bool correctFormat = false;
            while (!correctFormat)
            {
                string? input = Console.ReadLine();
                correctFormat = isPublicationFormate(input);
                if (correctFormat)
                {
                    publicationYear = int.Parse(input);
                }
            }
           
            Console.WriteLine("Author Details");
            Console.WriteLine("FirstName : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("LastName : ");
            string lastName = Console.ReadLine();
            Author author1 = new Author(firstName, lastName);

            books.Add(new Book(title, author1, publicationYear));
        }
        public static bool updateBook()
        {
            if (Book.HowManyBooksAvaliable == 0)
            {
                Console.WriteLine("There is No Book Right Now in Library, First Add book .");
                return false;
            }
            else
            {
                int id;
                Console.WriteLine("Enter BookID To Update : ");
                string input = Console.ReadLine();
                if (isInt(input))
                {
                    id = int.Parse(input);
                }
                else
                {
                    Console.WriteLine("Please enter only Integer Value...");
                    return false;
                }
              
                var book = books.FirstOrDefault(b => b.BookId == id);
                if (book == null)
                {
                    Console.WriteLine("Book with this ID is not avaliable!!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Title : ");
                    book.Title = Console.ReadLine();
                    Console.WriteLine("Publication Year : ");
                    bool correctFormat = false;
                    while (!correctFormat)
                    {
                         input = Console.ReadLine();
                        correctFormat = isPublicationFormate(input);
                        if (correctFormat)
                        {
                            book.PublicationYear = int.Parse(input);
                        }
                    }

                    Console.WriteLine("Author Details");
                    Console.WriteLine("FirstName : ");
                    book.Author.FirstName = Console.ReadLine();
                    Console.WriteLine("LastName : ");
                    book.Author.LastName = Console.ReadLine();

                    return true;
                }
            }
        }
        public static bool deleteBook() {
            if (Book.HowManyBooksAvaliable == 0)
            {
                Console.WriteLine("OOPSS, Library is Empty!!, First Add Book .");
                return false;
            }
            else
            {
                Console.WriteLine("Enter BookID To Delete : ");
                int id = int.Parse(Console.ReadLine());
                var book = books.FirstOrDefault(b => b.BookId == id);
                if (book == null)
                {
                    Console.WriteLine("Book with this ID is not avaliable!!");
                    return false;   
                }
                else
                {
                    books.Remove(book);
                    Book.HowManyBooksAvaliable--;
                    return  true;
                }
            }
        }
        public static void listAllBooks()
        {
            if(books.Count == 0)
            {
                Console.WriteLine("There is NO book in Library....");
            }
            else
            {
            foreach(var book in books) 
            {
                Console.WriteLine("BookID : "+book.BookId);
                Console.WriteLine("Title : " + book.Title);
                Console.WriteLine("Author FullName : "+book.Author.fullName());
                Console.WriteLine("Publication Year : "+book.PublicationYear);
                Console.WriteLine("============================================");
            }
            }
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
            authors.Add(new(firstName, lastName, dob));


        }
        public static void updateAuthor()
        {

        }
        public static void deleteAuthor()
        {

        }
        public static void listAllAuthors()
        {

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
        public static void displayBorrowedBooks()
        {

        }
        public static void searchBooks()
        {

        }
        public static void filterBooksByStatus()
        {

        }
        static void DisplayMenu()
        {
            // Display the menu options
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
    }

    // Class definitions
    class Book
    {
        public int BookId { get; set; } 
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; }
        public static int HowManyBooksAvaliable = 0;
        public Book(string title, Author author , int publicationYear) 
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            BookId = ++HowManyBooksAvaliable;
        }

    }

    class Author
    {
        public int AuthorId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public static int HowManyAuthors = 0;
        public string fullName() => $"{FirstName}\t{LastName}";
        public Author(string firstName , string lastName , DateTime dob)
        {
            AuthorId = ++HowManyAuthors;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
        }
        public Author ( string firstName , string lastName)
        {
            AuthorId = ++HowManyAuthors;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Borrower
    {
        public int BorrowerId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public static int howManyBorrowers = 0; 
        public Borrower(string firstName , string lastName , string email , string phoneNumber)
        {
            BorrowerId = ++howManyBorrowers;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }

    class BorrowedBook
    {
        public Book Book { get; set; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public BorrowedBook(Book book , string borrower , DateTime borrowDate , DateTime dueDate)
        {
            Book = book;
            Borrower = borrower;
            BorrowDate = borrowDate;
            DueDate = dueDate;
        }
    }

}