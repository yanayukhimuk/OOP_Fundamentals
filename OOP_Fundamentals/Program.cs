using Project_Library;

namespace OOP_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            DateTime expdate = DateTime.Now.AddDays(-100);
            string commonContainer = "C:\\Users\\Yana_Yukhimuk\\source\\repos\\OOP_Fundamentals\\OOP_Fundamentals\\UploadFiles.json";
            string bookContainer = @"C:\Users\Yana_Yukhimuk\source\repos\OOP_Fundamentals\OOP_Fundamentals\books.json";

            List<IPublication> list = new List<IPublication>();
            Book book1 = new Book(111, "Publisher_1", 01, date, PublicationType.Book, 56, "My Book", "My Author");
            Book book2 = new Book(222, "Publisher_1", 02, date, PublicationType.Book, 156, "My Book 2", "My Author 2");
            Book book3 = new Book(333, "Publisher_1", 03, date, PublicationType.Book, 256, "My Book 3", "My Author 3");
            Patent patent = new Patent(date, 04, expdate, PublicationType.Patent, 3, "My Patent", "Kate");
            LocalizedBook localizedBook = new LocalizedBook(444, "DOM", "Belarus", "BelPublisher", 05, date, PublicationType.LocalizedBook, 55, "Local", "Foreigner");

            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(localizedBook);
            list.Add(patent);

            Library library = new(commonContainer);
            library.UploadFiles(list, commonContainer);

            List<Book> LibBooks = library.LoadBooks(bookContainer);
            List<Patent> patens = library.LoadPatents("");
        }
    }
}