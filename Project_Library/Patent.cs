using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    internal class Patent : IPublication
    {
        public DateTime _expirationDate;
        public int Id { get;}

        public DateTime DatePublished { get; }

        public PublicationType Type { get; }

        public int PagesCount { get; }

        public string Title { get; }

        public string Author { get; }

        public Patent(DateTime expirationDate, int id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            _expirationDate = expirationDate;
            Id = id;
            DatePublished = datePublished;
            Type = type;
            PagesCount = pagesCount;
            Title = title;
            Author = author;
        }
    }
}
