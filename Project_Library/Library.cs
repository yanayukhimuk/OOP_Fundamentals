using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace Project_Library
{
    public class Library
    {
        string path;
        public List<IPublication> LibraryContent;

        public Library(string path)
        {
            this.path = path;
        }

        public List<BookJson> LoadBooks(string path)
        {
            List<BookJson> list;

            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<BookJson>>(json);
                reader.Close();
            }
            return list;
        }

        public List<PatentJson> LoadPatents(string path)
        {
            List<PatentJson> list;

            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<PatentJson>>(json);
                reader.Close();
            }
            return list;
        }

        public List<LocalizedBookJson> LoadLocalizedBooks(string path)
        {
            List<LocalizedBookJson> list;

            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<LocalizedBookJson>>(json);
                reader.Close();
            }
            return list;
        }

        public void UploadFiles(List<IPublication> files, string path)
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\Yana_Yukhimuk\source\repos\OOP_Fundamentals\OOP_Fundamentals\UploadFiles.json"))
            {
                foreach (var file in files)
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    serializer.Serialize(sw, file);
                }
            }
        }

        public Book SearchForDocument(string name, List<Book> books)
        {
            return (Book)books.Select(b => b.Title == name);  
        }

        public List<Book> GetAllBooks()
        {
            return LibraryContent.Where(t => t.Type == PublicationType.Book).Cast<Book>().ToList();
        }
    }
}
