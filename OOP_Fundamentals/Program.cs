using Project_Library;

namespace OOP_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            Library library = new(path);
            List<Book> books = library.GetAllBooks();
        }
    }
}