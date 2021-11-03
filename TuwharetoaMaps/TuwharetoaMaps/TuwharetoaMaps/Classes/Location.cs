using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuwharetoaMaps.Classes
{
    public class Location
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Details")]
        public string Details { get; set; }
        [JsonProperty("Image")]
        public Uri Image { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
    }
}
