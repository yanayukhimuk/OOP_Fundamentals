using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    [Serializable()]
    public class LocalizedBook : Publication
    {
        [JsonProperty("ISBN")]
        public int ISBN { get;  }
        public string OriginalPublisher { get; }
        public string CountryOfLocalization { get; }
        public string LocalPublisher { get; }

        public LocalizedBook(int iSBN, string originalPublisher, string countryOfLocalization, string localPublisher, Guid id, DateTime datePublished, PublicationType type, int pagesCount, string title, string author)
            :base(id, datePublished, type, pagesCount, title, author)
        {
            ISBN = iSBN;
            OriginalPublisher = originalPublisher;
            CountryOfLocalization = countryOfLocalization;
            LocalPublisher = localPublisher;
        }
    }
}
