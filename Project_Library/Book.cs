using System.Xml.Serialization;

namespace Project_Library
{
    public class Book : IPublication
    {
        public int? _ISBN;
        public string? _publisher;
        public int Id { get; }
        public DateTime DatePublished { get; }

        public PublicationType Type { get; }

        public int PagesCount { get; }

        public string Title { get; }

        public string Author { get; }

        public Book(int? iSBN, string? publisher, int id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            _ISBN = iSBN;

            if (string.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("The publisher is required.");
            _publisher = publisher;
            Id = id;
            DatePublished = datePublished;
            Type = type;

            if(pagesCount <= 0)
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
