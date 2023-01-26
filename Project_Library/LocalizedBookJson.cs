using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    [Serializable()]
    public class LocalizedBookJson
    {
        [JsonProperty("localized_book")]
        public LocalizedBook LocalizedBook { get; set; }
    }
}
