using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Entities
{
    public class Problem
    {
        public string StandardProblemTypeNamespace { get; set; }
        public string Type { get; set; }
        public string Detail { get; set; }
        public int? Status { get; set; }
    }
}
