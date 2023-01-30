using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    [Serializable()]
    public class Patent : Publication
    {
        public DateTime ExpirationDate { get;  }

        public Patent(DateTime expirationDate, Guid id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
            : base (id, datePublished, type, pagesCount, title, author)
        {
            ExpirationDate = expirationDate;
        }
    }
}
