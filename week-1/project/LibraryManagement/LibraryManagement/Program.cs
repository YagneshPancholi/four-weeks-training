using System.Diagnostics;


namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Utilities.DisplayMenu();

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Book.addBook();
                        Utilities.showSuccessMessage("Book Added");
                        break;
                     case 2:
                        if (Book.updateBook())
                        {
                            Utilities.showSuccessMessage("Book Updated");
                        }
                        else
                        {
                            Utilities.showUnsuccessMessage("Book Updated");
                        }
                        break;  
                     case 3:
                        if (Book.deleteBook())
                        {
                            Utilities.showSuccessMessage("Book Deleted");
                        }
                        else
                        {
                            Utilities.showUnsuccessMessage("Book Deleted");
                        }
                        break;
                     case 4:
                        Book.listAllBooks();                            
                        break;
                     case 5:
                        Author.addAuthor();
                        Utilities.showSuccessMessage("Author Added");
                        break;
                     case 6:
                        if (Author.updateAuthor())
                        {
                            Utilities.showSuccessMessage("Author Updated");
                        }
                        else
                        {
                            Utilities.showUnsuccessMessage("Author Update");
                        }
                            break;
                     case 7:
                        if (Author.deleteAuthor())
                        {
                            Utilities.showSuccessMessage("Author Deleted");
                        }
                        else
                        {
                            Utilities.showUnsuccessMessage("Author Delete");
                        }
                        break;
                     case 8:
                        Author.listAllAuthors();
                        break;
                     case 9:
                        Borrower.addBorrower();
                        Utilities.showSuccessMessage("Borrower Added");
                        break;
                     case 10:
                        Borrower.updateBorrower();
                         break;
                     case 11:
                        Borrower.deleteBorrower();
                         break;
                     case 12:
                        Borrower.listAllBorrowers();
                         break;
                     case 13:
                        Borrower.registerBookToBorrower();
                         break;
                     case 14:
                        BorrowedBook.displayBorrowedBooks();
                         break;
                    case 15:
                        Book.searchBooks();
                         break;
                    case 16:
                        Book.filterBooksByStatus();
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
    }
}