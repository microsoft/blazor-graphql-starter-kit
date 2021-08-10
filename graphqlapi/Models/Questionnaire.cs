using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class Questionnaire : DomainResource
    {
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("identifier")]
        public IList<Identifier> Identifier { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("status")]
        public PublicationStatus Status { get; set; }

        [JsonPropertyName("experimental")]
        public bool Experimental { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("approvalDate")]
        public DateTime ApprovalDate { get; set; }

        [JsonPropertyName("lastReviewDate")]
        public DateTime LastReviewDate { get; set; }

        [JsonPropertyName("effectivePeriod")]
        public Period EffectivePeriod { get; set; }

        [JsonPropertyName("item")]
        public IList<QuestionnaireItem> Items { get; set; }
    }
}
