using Project_Library;

namespace OOP_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            List<Book> books = new List<Book>();

            books = library.GetBooks();
        }
    }
}