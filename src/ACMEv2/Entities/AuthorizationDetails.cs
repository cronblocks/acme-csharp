using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Entities
{
    public class AuthorizationDetails
    {
        [JsonProperty("identifier", Required = Required.Always)]
        public Identifier Identifier { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        [Required]
        public string Status { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("challenges")]
        [Required]
        public Challenge[] Challenges { get; set; }

        [JsonProperty("wildcard")]
        public bool? Wildcard { get; set; }
    }
}
