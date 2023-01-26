using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project_Library
{
    internal class Library
    {
        public List<IPublication> LibraryContent;

        public Library()
        {
            LibraryContent = LoadFiles();
        }

        public List<IPublication> LoadFiles(string path)
        {
            List<IPublication> fileList = new List<IPublication>();
            XmlSerializer serializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                try
                {
                    fileList = (List<IPublication>)serializer.Deserialize(fs);
                    fs.Close();
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException("The action cannot be performed");
                }
            }
            return fileList;
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
