using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project_Library
{
    public class Library
    {
        string path;
        public List<IPublication> LibraryContent;

        public Library(string path)
        {
            this.path = path;
            LibraryContent = LoadFiles(path);
        }

        public List<IPublication> LoadFiles(string path)
        {
            string text = File.ReadAllText(path);
            var content = JsonSerializer.Deserialize<List<IPublication>>(text);
            return content;
        }
        public void SearchForDocument(int number)
        {

        }

        public List<Book> GetAllBooks()
        {
            return LibraryContent.Where(t => t.Type == PublicationType.Book).Cast<Book>().ToList();
        }
    }
}
