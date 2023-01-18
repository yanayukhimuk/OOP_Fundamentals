using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    internal class LocalizedBook : IPublication
    {
        public int? _ISBN;
        public string? _originalPublisher;
        public string? _countryOfLocalization;
        public string? _localPublisher;
        public int Id { get; }

        public DateTime DatePublished { get; }

        public PublicationType Type { get; }

        public int PagesCount { get; }

        public string Title { get; }

        public string Author { get; }

        public LocalizedBook(int? iSBN, string? originalPublisher, string? countryOfLocalization, string? localPublisher, int id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            _ISBN = iSBN;
            _originalPublisher = originalPublisher;
            _countryOfLocalization = countryOfLocalization;
            _localPublisher = localPublisher;
            Id = id;
            DatePublished = datePublished;
            Type = type;
            PagesCount = pagesCount;
            Title = title;
            Author = author;
        }
    }
}
