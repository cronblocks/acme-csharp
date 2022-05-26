using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Entities
{
    public class Order
    {
        public string OrderUrl { get; set; }
        public string Status { get; set; }
        public DateTime Expires { get; set; }
        public string[] DnsIdentifiers { get; set; }
        public IEnumerable<Authorization> Authorizations { get; set; }
        public string FinalizeUrl { get; set; }
        public string CertificateUrl { get; set; }
    }
}
