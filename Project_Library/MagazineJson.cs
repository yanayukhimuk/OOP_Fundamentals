﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    [Serializable()]
    public class MagazineJson
    {
        [JsonProperty("magazine")]
        public Magazine Magazine { get; set; }
    }
}
