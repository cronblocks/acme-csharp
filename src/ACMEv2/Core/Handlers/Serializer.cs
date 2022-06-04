using CronBlocks.ACMEv2.Core.InternalInterfaces;
using System.Text.Json;

namespace CronBlocks.ACMEv2.Core.Handlers
{
    internal class Serializer : ISerializer
    {
        public string SerializeToJson<T>(T obj)
        {
            if (obj == null)
            {
                return null;
            }

            return JsonSerializer.Serialize(obj);
        }

        public T DeserializeFromJson<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
