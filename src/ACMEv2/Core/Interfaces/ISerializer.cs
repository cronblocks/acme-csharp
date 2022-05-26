using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Interfaces
{
    internal interface ISerializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string json);
    }
}
