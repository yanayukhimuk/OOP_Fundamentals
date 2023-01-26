using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Project_Library
{
    [Serializable()]
    public class Book : IPublication
    {
        [JsonProperty("ISBN")]
        public int ISBN { get; }
        [JsonProperty("Publisher")]
        public string Publisher { get;  }
        [JsonProperty("Id")]
        public int Id { get;  }
        [JsonProperty("DatePublished")]
        public DateTime DatePublished { get; }
        [JsonProperty("Type")]
        public PublicationType Type { get;  }
        [JsonProperty("PagesCount")]
        public int PagesCount { get; }
        [JsonProperty("Title")]
        public string Title { get; }
        [JsonProperty("Author")]
        public string Author { get;  }

        public Book(int iSBN, string publisher, int id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            ISBN = iSBN;

            if (string.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("The publisher is required.");
            Publisher = publisher;
            Id = id;
            DatePublished = datePublished;
            Type = type;

            if (pagesCount <= 0)
                throw new ArgumentOutOfRangeException("The number of pages should be more than 0");
            PagesCount = pagesCount;

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The title is required.");
            Title = title;
            Author = author;
        }

        public BookCardDTO ShowData()
        {
            return new BookCardDTO(Id, Title);
            //return String.Format("Publication Type: {0}, Id: {1}, Title: {2}, Date published: {3}, Author: {4}, ISBN: {5}, Publisher: {6}, Pages count: {7}", Type, Id, Title, DatePublished, Author, _ISBN, _publisher, PagesCount);
        }
    }
}
