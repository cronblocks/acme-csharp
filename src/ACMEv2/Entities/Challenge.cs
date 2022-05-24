using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Entities
{
    public class Challenge
    {
        public string Type { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public string Validated { get; set; }
        public object[] ValidationRecord { get; set; }
        public object Error { get; set; }
        public string Token { get; set; }
    }
}
