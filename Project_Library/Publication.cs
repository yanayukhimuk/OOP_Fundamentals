using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_Library
{
    public class Publication : IPublication
    {
        public Publication(Guid id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            Id = id;
            DatePublished = datePublished;
            Type = type;

            if (pagesCount <= 0)
                throw new ArgumentOutOfRangeException("The number of pages should be more than 0");
            PagesCount = pagesCount;

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The title is required.");
            Title = title;

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("The title is required.");
            Author = author;
        }

        public Guid Id { get; } 
        public DateTime DatePublished { get; }

        public PublicationType Type { get; }

        public int PagesCount { get; }

        public string Title { get; }

        public string Author { get; }

        public string Serialize() => JsonSerializer.Serialize(this);
    }
}
