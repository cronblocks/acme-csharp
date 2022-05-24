using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Entities
{
    public class Authorization
    {
        public string DetailsUrl { get; set; }
        public string FetchError { get; set; }
        public AuthorizationDetails AuthorizationDetails { get; set; }
    }
}
