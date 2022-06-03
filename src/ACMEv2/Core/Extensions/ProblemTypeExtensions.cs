using CronBlocks.ACMEv2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Extensions
{
    internal static class ProblemTypeExtensions
    {
        public static string Description(this ProblemType problemType)
        {
            return "Unknown";
        }
    }
}
