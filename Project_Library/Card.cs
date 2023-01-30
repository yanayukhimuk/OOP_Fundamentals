using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public class Card<T> where T : IPublication
    {
        public Guid Id { get; set; }
        public string Stock { get; set; }
        public T Publication { get; set; }

        public Card(T publication, string stock)
        {
            Id = Guid.NewGuid(); 
            Publication= publication;   
            Stock = stock;
        }

    }
}
