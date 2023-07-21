using BookStoreApp.Models;

namespace BookStoreApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(BookContext context)
        {
            if(context.Books.Any() || context.Authors.Any() )
            {
                return;
            }

            //creating authors 
            Author a1 = new()
            {
                FirstName = "Morgan",
                LastName = "Housel"
            };
            Author a2 = new()
            {
                FirstName = "David",
                LastName = "Gogins"
            };
            Author a3 = new()
            {
                FirstName = "Ankur",
                LastName = "Warikoo"
            };
            var authors = new Author[]
            {
                a1,a2, a3
            };

            //add authors to DB
            context.AddRange(authors);

            //creating books objects
            var books = new Book[]{
                new Book { Title ="Psycology Of Money", Genre = "NonFiction, Finance",
                    Price = 250,
                    Author = a1 },
                new Book { Title ="Can't Hurt Me", Genre = "NonFiction, Finance, SelfHelp",
                    Price = 300,
                    Author = a2 },
                new Book { Title ="Lets Talk About Money", Genre = "NonFiction, Finance",
                    Price = 150,
                    Author = a3 },
                new Book { Title ="Atomic Habits", Genre = "NonFiction, Growth",
                    Price = 450,
                    Author = new Author{ FirstName ="James", LastName = "Clear"} },
                new Book { Title ="Do Epic Shit", Genre = "SelfHelp, Growth",
                    Price = 200,
                    Author = a3 }
            };

            // add books to DB
            context.AddRange(books);

            context.SaveChanges();
        }
    }
}
