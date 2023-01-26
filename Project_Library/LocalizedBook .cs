using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    [Serializable()]
    public class LocalizedBook : IPublication
    {
        [JsonProperty("ISBN")]
        public int ISBN { get; set; }
        [JsonProperty("OriginalPublisher")]
        public string OriginalPublisher { get; set; }
        [JsonProperty("CountryOfLocalization")]
        public string CountryOfLocalization { get; set; }
        [JsonProperty("LocalPublisher")]
        public string LocalPublisher { get; set; }
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

        public LocalizedBook(int iSBN, string originalPublisher, string countryOfLocalization, string localPublisher, int id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
        {
            ISBN = iSBN;
            OriginalPublisher = originalPublisher;
            CountryOfLocalization = countryOfLocalization;
            LocalPublisher = localPublisher;
            Id = id;
            DatePublished = datePublished;
            Type = type;
            PagesCount = pagesCount;
            Title = title;
            Author = author;
        }
    }
}
