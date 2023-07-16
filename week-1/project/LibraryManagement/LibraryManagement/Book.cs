using System;


public class Book
{
	static List<Book> books = new List<Book>();

	public int BookId { get; set; }
	public string Title { get; set; }
	public Author Author { get; set; }
	public int PublicationYear { get; set; }
	public bool IsAvailable { get; set; }
	public static int HowManyBooksAvaliable = 0;
	public Book(string title, Author author, int publicationYear)
	{
		Title = title;
		Author = author;
		PublicationYear = publicationYear;
		BookId = ++HowManyBooksAvaliable;
		IsAvailable = true;
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
			correctFormat = Utilities.isPublicationFormate(input);
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
					string input = Console.ReadLine();
					correctFormat = Utilities.isPublicationFormate(input);
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

	public static bool deleteBook()
	{
		if (Book.HowManyBooksAvaliable == 0)
		{
			Console.WriteLine("OOPSS, Library is Empty!!, First Add Book .");
			return false;
		}
		else
		{
			int id = -1;
			bool isIntFlag = false;
			while (!isIntFlag)
			{
				Console.WriteLine("Enter BookID To Delete : ");
				string input = Console.ReadLine();
				if (Utilities.isInt(input))
				{
					id = int.Parse(input);
					isIntFlag = true;
				}
			}
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
				return true;
			}
		}
	}
	public static void listAllBooks()
	{
		if (books.Count == 0)
		{
			Console.WriteLine("There is NO book in Library....");
		}
		else
		{
			foreach (var book in books)
			{
				Console.WriteLine("BookID : " + book.BookId);
				Console.WriteLine("Title : " + book.Title);
				Console.WriteLine("Author FullName : " + book.Author.fullName());
				Console.WriteLine("Publication Year : " + book.PublicationYear);
				if (book.IsAvailable)
					Console.WriteLine("Avaliable : YES");
				else
					Console.WriteLine("Avaliabe : NO");
				Console.WriteLine("============================================");
			}
		}
	}
	public static void searchBooks()
	{
		Console.WriteLine("I am here");
		Console.WriteLine("Enter KeyWord To Search : ");
		string keyword = Console.ReadLine().ToLower();
		var result = books.Where(b => b.Title.ToLower().Contains(keyword) || b.Author.FirstName.ToLower().Contains(keyword) || b.Author.LastName.ToLower().Contains(keyword) || b.PublicationYear.ToString().Contains(keyword)).ToList();
		if(result.Any())
		{
			foreach (var book in result)
			{
				Console.WriteLine("BookID : " + book.BookId);
				Console.WriteLine("Title : " + book.Title);
				Console.WriteLine("Author FullName : " + book.Author.fullName());
				Console.WriteLine("Publication Year : " + book.PublicationYear);
				Console.WriteLine("============================================");
				if (book.IsAvailable)
					Console.WriteLine("Avaliable : YES");
				else
					Console.WriteLine("Avaliabe : NO");
			}
		}
		else
		{
			Console.WriteLine("Sorry, No Search Result Found");
		}
		
	}
	public static void filterBooksByStatus()
	{
		var results = books.Where(b => b.IsAvailable == true).ToList();
		Console.WriteLine("All Avaliable Books ");
		foreach (var book in results)
		{
			Console.WriteLine("BookID : " + book.BookId);
			Console.WriteLine("Title : " + book.Title);
			Console.WriteLine("Author FullName : " + book.Author.fullName());
			Console.WriteLine("Publication Year : " + book.PublicationYear);
			Console.WriteLine("============================================");
		}

	}

}