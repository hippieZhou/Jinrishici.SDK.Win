using Newtonsoft.Json;
using System;

namespace Jinrishici.SDK.Win.Models
{
    public class PoetySentence
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Data Data { get; set; }

        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
    }

    public class Data
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "popularity")]
        public int Popularity { get; set; }

        [JsonProperty(PropertyName = "origin")]
        public Origin Origin { get; set; }

        [JsonProperty(PropertyName = "matchTags")]
        public string[] MatchTags { get; set; }

        [JsonProperty(PropertyName = "recommendedReason")]
        public string RecommendedReason { get; set; }

        [JsonProperty(PropertyName = "cacheAt")]
        public DateTime CacheAt { get; set; }
    }

    public class Origin
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "dynasty")]
        public string Dynasty { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string[] Content { get; set; }

        [JsonProperty(PropertyName = "translate")]
        public string[] Translate { get; set; }
    }
}
