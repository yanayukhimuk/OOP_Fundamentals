using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    internal class BookCard : ICard
    {
        public Book _newBook;
        public PublicationType DocumentType { get; set; }
        public int CardId { get; set; }

        public BookCard(int cardId, Book newBook)
        {
            DocumentType = newBook.Type;
            CardId = cardId;
            _newBook = newBook;
        }

        public void ShowCardData()
        {
            Console.WriteLine("Publication Type: {0}, Id: {1}, Title: {2}, Date published: {3}, Author: {4}, ISBN: {5}, Publisher: {6}, Pages count: {7}", _newBook.Type, _newBook.Id, _newBook.Title, _newBook.DatePublished, _newBook.Author, _newBook._ISBN, _newBook._publisher, _newBook.PagesCount);
        }
    }
}
