using Newtonsoft.Json;

namespace Project_Library
{
    [Serializable()]
    public class PatentJson
    {
        [JsonProperty("patent")]
        public Patent Patent { get; set; }
    }
}
