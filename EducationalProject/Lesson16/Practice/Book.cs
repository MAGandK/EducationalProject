namespace Lesson16
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Pages { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public Book(int id, string title, int pages, string author, int year)
        {
            Id = id;
            Title = title;
            Pages = pages;
            Author = author;
            Year = year;
        }

        public Book()
        {

        }
    }
}
