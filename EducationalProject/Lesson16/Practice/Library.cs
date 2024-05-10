namespace Lesson16
{
	public static class Library
	{
		public static Dictionary<int, Book>? Books { get; private set; }

		public static void Initialize()
		{
			Books = new Dictionary<int, Book> {
				{ 1, new Book { Id = 1, Title = "The Lord of the Rings", Author = "Tolkien", Pages = 1178, Year = 1954 } },
				{ 2, new Book { Id = 2, Title = "The Hobbit", Author = "Tolkien", Pages = 310, Year = 1937 } },
				{ 3, new Book { Id = 3, Title = "Harry Potter and the Philosopher's Stone", Author = "Rowling", Pages = 223, Year = 1997 } },
				{ 4, new Book { Id = 4, Title = "Game of Thrones", Author = "Martin", Pages = 694, Year = 1996 } },
				{ 5, new Book { Id = 5, Title = "1984", Author = "Orwell", Pages = 328, Year = 1949 } },
				{ 6, new Book { Id = 6, Title = "To Kill a Mockingbird", Author = "Lee", Pages = 324, Year = 1960 } },
				{ 7, new Book { Id = 7, Title = "The Great Gatsby", Author = "Fitzgerald", Pages = 180, Year = 1925 } }
			};
		}


		public static void GetBooksByAuthor(string author)
		{
			var result = Books.Values.Where(b => b.Author == author);

			Console.WriteLine($"Книги автора {author}:  ");

			foreach (var item in result)
			{
				Console.WriteLine($"Книга {item.Title}");
			}
		}

		public static void GetBookCount()
		{
			var bookCount = Books.Count;

			Console.WriteLine($"Общее количество книг в библиотеке: {bookCount}");
		}

		public static void GetBookWithMaxPages()
		{
			var result = Books.Values.OrderByDescending(b => b.Pages).First();

			Console.WriteLine($"Results of getting a book with max pages {result.Pages}): {result.Title}");
		}

		public static void GetBooksSorterbyYearDescending()
		{
			var result = Books.Values.OrderByDescending(b => b.Year);
			Console.WriteLine("Книги отсортированные по году издания: ");
			foreach (var book in result)
			{
				Console.WriteLine($"Название книги{book.Title} год {book.Year}");
			}
		}

		public static void GetBooksFilteredByYear(int year)
		{
			var booksFilteredByYear = Books.Values.Where(b => b.Year > year);
			Console.WriteLine($"Книги изданные после {year} года ");

			foreach (var book in booksFilteredByYear)
			{
				Console.WriteLine(book.Title);
			}
		}
	}
}
