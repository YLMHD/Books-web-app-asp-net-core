namespace BooksWebApp.Models
{
    public class Books
    {
        public int Id { get; set; } 

        public string Title { get; set; } = null!;
        public string description { get; set; } = null!;

        public Books()
        {
        }

    }
}
