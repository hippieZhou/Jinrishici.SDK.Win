using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jinrishici.SDK.Win.Models
{
    [JsonObject]
    public class PoetyToken
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        [JsonProperty(PropertyName = "data")]
        public string Token { get; set; }

        public override string ToString() => Token;
    }
}
