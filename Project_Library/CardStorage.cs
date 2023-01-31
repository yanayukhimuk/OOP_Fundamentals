using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public class CardStorage<T> : IStorage<T> where T : Publication
    {
        public IEnumerable<Card<T>> Items { get; set; }
        public CardStorage(List<Card<T>> items)
        {
            Items = items;
        }
        public Card<T> GetCardById(Guid id)
        {
            return Items.Select(item => item).Where(i => i.Id == id).FirstOrDefault();
        }
        public Card<T> GetCardByPublicationId(Guid id)
        {
            return Items.Select(item => item).Where(i => i.Publication.Id == id).FirstOrDefault();
        }
        public IEnumerable<Card<T>> GetListByAuthor(string author)
        {
            return Items.Select(item => item).Where(i => i.Publication.Author == author).ToList();
        }
    }
}
