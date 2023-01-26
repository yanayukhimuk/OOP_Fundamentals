using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{ 
    public interface IPublication
    {
        public int Id { get; }
        public DateTime DatePublished { get; }
        public PublicationType Type { get; }
        public int PagesCount { get; }
        public string Title { get; }
        public string Author { get; }
    }
}
