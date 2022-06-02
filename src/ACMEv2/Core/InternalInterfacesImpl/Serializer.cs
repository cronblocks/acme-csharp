using CronBlocks.ACMEv2.Core.InternalInterfaces;
using System;
using System.Text.Json;

namespace CronBlocks.ACMEv2.Core.InternalInterfacesImpl
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

        public string SerializeToBase64(byte[] bytes, bool removeTrailingEquals = true)
        {
            if (bytes == null)
            {
                return "";
            }

            return SerializeToBase64(bytes, 0, bytes.Length, removeTrailingEquals);
        }

        string SerializeToBase64(byte[] bytes, int start, int total, bool removeTrailingEquals = true)
        {
            if (bytes == null)
            {
                return "";
            }

            string b64 = Convert.ToBase64String(bytes, start, total, Base64FormattingOptions.None);

            return removeTrailingEquals ? b64.Replace("=", "") : b64;
        }

        public byte[] DeserializeFromBase64(string serializedBase64)
        {
            if (string.IsNullOrEmpty(serializedBase64))
            {
                return null;
            }

            return Convert.FromBase64String(serializedBase64);
        }
    }
}
