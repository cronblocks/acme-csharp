using CronBlocks.ACMEv2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CronBlocks.ACMEv2.Core.DefaultInterfacesImpl
{
    internal class Serializer : ISerializer
    {
        public string Serialize<T>(T obj)
        {
            if (obj == null)
            {
                return null;
            }

            return JsonSerializer.Serialize(obj);
        }

        public T Deserialize<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
