using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public interface IStorage<T> where T : IPublication
    {
        public Card<T> GetCardById(Guid id);
        public IEnumerable<Card<T>> GetListByAuthor(string author);
    }
}
