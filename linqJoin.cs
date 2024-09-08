// NOTE: This project does not include a separate README file.

// Task: Create a library management system with two tables: Authors and Books.
//       The system should perform the following tasks:
//       1. Define the Author and Book classes.
//       2. Add sample data to the Authors and Books collections.
//       3. Create a LINQ query to join the Authors and Books tables based on the AuthorId.
//       4. Print the results, including the book title and author name.

namespace ConsoleApp1
{
    public class Program
    {
        // Creating Author Class
        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }
        }

        // Creating Book Class
        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
        }

        private static void Main(string[] args)
        {
            List<Author> authors = new List<Author>(); // Author collection and some samples
            authors.Add(new Author { AuthorId = 1, Name = "J.K. Rowling" });
            authors.Add(new Author { AuthorId = 2, Name = "J.R.R. Tolkien" });
            authors.Add(new Author { AuthorId = 3, Name = "George R.R. Martin" });
            authors.Add(new Author { AuthorId = 4, Name = "Stephen King" });
            authors.Add(new Author { AuthorId = 5, Name = "Neil Gaiman" });

            List<Book> books = new List<Book>();       // Book collection and some samples
            books.Add(new Book { BookId = 1, Title = "Harry Potter", AuthorId = 1 });
            books.Add(new Book { BookId = 2, Title = "The Lord of the Rings", AuthorId = 2 });
            books.Add(new Book { BookId = 3, Title = "Game of Thrones", AuthorId = 3 });
            books.Add(new Book { BookId = 4, Title = "The Shining", AuthorId = 4 });
            books.Add(new Book { BookId = 5, Title = "American Gods", AuthorId = 5 });

            // Create a LINQ query to join the books and authors. This query should include the book title and author name.
            var booksWithAuthors = from author in authors
                                   join book in books
                                   on author.AuthorId equals book.AuthorId
                                   select new
                                   {
                                       AuthorName = author.Name,
                                       BookName = book.Title
                                   };

            // Print the results
            Console.WriteLine("BOOKS AND THE AUTHORS\n---");
            if (booksWithAuthors.Any())
                                                         // Print the books and authors collection
                foreach (var item in booksWithAuthors) { Console.WriteLine($"Author Name : {item.AuthorName}\nBook Name   : {item.BookName}\n---"); }
            else
                Console.WriteLine("Kitaplar ve yazarlar bulunamadı.");
        }
    }
}
