using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    internal class LocalizedBookCard : ICard
    {
        public LocalizedBook _localBook;
        public PublicationType DocumentType { get; set; }
        public int CardId { get; set; }

        public LocalizedBookCard(LocalizedBook localBook, int cardId)
        {
            DocumentType = localBook.Type;
            CardId = cardId;
            _localBook = localBook;
        }

        public void ShowCardData()
        {
            Console.WriteLine("Publication Type: {0}, Id: {1}, Title: {2}, Date published: {3}, Author: {4}, ISBN: {5}, Local Publisher: {6}, Original Publisher: {7}, Country of localization: {8}, Pages count: {9}", _localBook.Type, _localBook.Id, _localBook.Title, _localBook.DatePublished, _localBook.Author, _localBook._ISBN, _localBook._localPublisher, _localBook._originalPublisher, _localBook.PagesCount);
        }
    }
}
