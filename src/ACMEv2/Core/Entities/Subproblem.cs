﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Entities
{
    public class Subproblem
    {
        public string Type { get; set; }
        public string Detail { get; set; }
        public Identifier Identifier { get; set; }
    }
}
