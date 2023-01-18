using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    internal class PatentCard : ICard
    {
        public Patent _patent;
        public PublicationType DocumentType { get; set; }
        public int CardId { get; set; }
        public PatentCard(Patent patent, int cardId)
        {
            DocumentType = patent.Type;
            CardId = cardId;
            _patent = patent;
        }

        public void ShowCardData()
        {
            Console.WriteLine("Publication Type: {0}, Id: {1}, Title: {2}, Date published: {3}, Author: {4}, Pages count: {5}, Expiration date: {6}", _patent.Type, _patent.Id, _patent.Title, _patent.DatePublished, _patent.Author, _patent.PagesCount, _patent._expirationDate);
        }
    }
}
