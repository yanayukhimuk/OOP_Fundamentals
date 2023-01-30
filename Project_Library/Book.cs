using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Project_Library
{
    [Serializable()]
    public class Book : Publication
    {
        [JsonProperty("ISBN")]
        public int ISBN { get; }
        public string Publisher { get;  }

        public Book(int iSBN, string publisher, Guid id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author) 
            : base(id, datePublished, type, pagesCount, title, author)
        {
            ISBN = iSBN;

            if (string.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("The publisher is required.");
            Publisher = publisher;
        }

        public BookCardDTO ShowData()
        {
            return new BookCardDTO(Id, Title);
            //return String.Format("Publication Type: {0}, Id: {1}, Title: {2}, Date published: {3}, Author: {4}, ISBN: {5}, Publisher: {6}, Pages count: {7}", Type, Id, Title, DatePublished, Author, _ISBN, _publisher, PagesCount);
        }
    }
}
