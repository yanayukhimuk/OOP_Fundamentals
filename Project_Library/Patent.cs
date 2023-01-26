using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    [Serializable()]
    public class Patent : IPublication
    {
        [JsonProperty("ExpirationDate")]
        public DateTime ExpirationDate { get; set; }
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("DatePublished")]
        public DateTime DatePublished { get; set; }
        [JsonProperty("Type")]
        public PublicationType Type { get; set; }
        [JsonProperty("PagesCount")]
        public int PagesCount { get; set; }
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("Author")]
        public string Author { get; set; }

        public Patent(DateTime expirationDate, int id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            ExpirationDate = expirationDate;
            Id = id;
            DatePublished = datePublished;
            Type = type;
            PagesCount = pagesCount;
            Title = title;
            Author = author;
        }
    }
}
