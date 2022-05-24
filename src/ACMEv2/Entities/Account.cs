﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Entities
{
    public class Account
    {
        public string Id { get; set; }
        public object Key { get; set; }
        public string[] Contact { get; set; }
        public string Status { get; set; }
        public bool? TermsOfServiceAgreed { get; set; }
        public string Orders { get; set; }
        public string InitialIp { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Agreement { get; set; }
    }
}
