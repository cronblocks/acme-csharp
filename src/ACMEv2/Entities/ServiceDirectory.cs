using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Entities
{
    public class ServiceDirectory
    {
        public Dictionary<string, object> extra { get; set; } = new Dictionary<string, object>();
        public string Directory { get; set; }
        public string NewNonce { get; set; }
        public string NewAccount { get; set; }
        public string NewOrder { get; set; }
        public string NewAuthz { get; set; }
        public string RevokeCert { get; set; }
        public string KeyChange { get; set; }
        public ServiceDirectoryMeta Meta { get; set; }
    }
}
