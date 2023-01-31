using Project_Library;

namespace OOP_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            DateTime expdate = DateTime.Now.AddDays(-100);
            string commonContainer = @"C:\\Users\\Yana_Yukhimuk\\source\\repos\\OOP_Fundamentals\\OOP_Fundamentals\\UploadFiles.json";
            string bookContainer = @"C:\Users\Yana_Yukhimuk\source\repos\OOP_Fundamentals\OOP_Fundamentals\books.json";
            string localizedBookContainer = @"C:\Users\Yana_Yukhimuk\source\repos\OOP_Fundamentals\OOP_Fundamentals\localizedBooks.json";
            string patentContainer = @"C:\Users\Yana_Yukhimuk\source\repos\OOP_Fundamentals\OOP_Fundamentals\patents.json";
            string magazineContainer = @"C:\Users\Yana_Yukhimuk\source\repos\OOP_Fundamentals\OOP_Fundamentals\magazines.json";

            List<Publication> list = new List<Publication>();
            Book book1 = new Book(111, "Publisher_1", Guid.NewGuid(), date, PublicationType.Book, 56, "My Book", "My Author");
            Book book2 = new Book(222, "Publisher_1", Guid.NewGuid(), date, PublicationType.Book, 156, "My Book 2", "My Author 2");
            Book book3 = new Book(333, "Publisher_1", Guid.NewGuid(), date, PublicationType.Book, 256, "My Book 3", "My Author 3");
            Patent patent = new Patent(date, Guid.NewGuid(), expdate, PublicationType.Patent, 3, "My Patent", "Kate");
            Magazine magazine = new Magazine(Guid.NewGuid(), date, PublicationType.Magazine, 45, "My Magazine", "Jane Black");
            Magazine magazine2 = new Magazine(Guid.NewGuid(), date, PublicationType.Magazine, 35, "My Magazine 2", "Jane Black");
            Magazine magazine3 = new Magazine(Guid.NewGuid(), date, PublicationType.Magazine, 25, "My Magazine 3", "Jane Black");
            LocalizedBook localizedBook = new LocalizedBook(444, "DOM", "Belarus", "BelPublisher", Guid.NewGuid(), date, PublicationType.LocalizedBook, 55, "Local", "Foreigner");

            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(localizedBook);
            list.Add(patent);
            list.Add(magazine);
            list.Add(magazine2);
            list.Add(magazine3);

            JSONRepository<Book> bookLibrary = new JSONRepository<Book>(bookContainer, commonContainer);
            List<Book> LibBooks = bookLibrary.DownloadFiles();
            bookLibrary.UploadFiles(LibBooks);

            JSONRepository<LocalizedBook> localLib = new JSONRepository<LocalizedBook>(localizedBookContainer, commonContainer);
            List<LocalizedBook> localBooks = localLib.DownloadFiles();
            localLib.UploadFiles(localBooks);

            JSONRepository<Patent> patentsLib = new JSONRepository<Patent>(patentContainer, commonContainer);
            List<Patent> patents = patentsLib.DownloadFiles();
            patentsLib.UploadFiles(patents);

            JSONRepository<Magazine> magazinesLib = new JSONRepository<Magazine>(magazineContainer, magazineContainer);
            List<Magazine> magazines = magazinesLib.DownloadFiles();
            magazinesLib.UploadFiles(magazines);

            List<Publication> newList = new List<Publication>();
            newList.AddRange(patents);
            newList.AddRange(localBooks);
            newList.AddRange(LibBooks);
            newList.AddRange(magazines);

            List <Card<Publication>> cardlist = new List<Card<Publication>>();
            foreach (var file in newList)
            {
                Card<Publication> card = new Card<Publication> (file, "1");
                cardlist.Add(card);
            }
            CardStorage<Publication> cardStorage = new CardStorage<Publication>(cardlist);

            Guid id = Guid.Parse("4b7877cc-fcb5-41ad-9f14-63639b3d65d6");
            var cardGet = cardStorage.GetCardById(id);

            var foundItems = cardStorage.GetListByAuthor("Kate");
        }
    }
}