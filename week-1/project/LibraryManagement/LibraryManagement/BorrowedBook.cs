using System;

public class BorrowedBook
{
    static List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();
    public Book Book { get; set; }
    public string Borrower { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public BorrowedBook(Book book, string borrower, DateTime borrowDate, DateTime dueDate)
    {
        Book = book;
        Borrower = borrower;
        BorrowDate = borrowDate;
        DueDate = dueDate;
    }
    public static void displayBorrowedBooks()
    {

    }
}