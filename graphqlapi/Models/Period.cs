using System;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class Period : Element
    {
        [JsonPropertyName("start")]
        public DateTime Start { get; set; }

        [JsonPropertyName("end")]
        public DateTime End { get; set; }
    }
}
