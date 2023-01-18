namespace Project_Library
{
    internal class Book : IPublication
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
    }
}
