using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    [Serializable()]
    public class Magazine : IPublication
    {
        [JsonProperty]
        public int Id {get;set;}
        [JsonProperty]
        public DateTime DatePublished { get; set; }
        [JsonProperty]
        public PublicationType Type { get; set; }
        [JsonProperty]
        public int PagesCount { get; set; }
        [JsonProperty]
        public string Title { get; set; }
        [JsonProperty]
        public string Author { get; set; }

        public Magazine(int id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            Id = id;
            DatePublished = datePublished;
            Type = type;
            PagesCount = pagesCount;
            Title = title;
            Author = author;
        }
    }
}
