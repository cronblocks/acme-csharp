using System.Text.Json;

namespace CronBlocks.ACMEv2.Core.Extensions
{
    internal static class JsonExtensions
    {
        private static readonly JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static string SerializeToJson<T>(this T obj)
        {
            if (obj == null)
            {
                return null;
            }

            return JsonSerializer.Serialize(obj, serializerOptions);
        }

        public static T DeserializeFromJson<T>(this string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(json, serializerOptions);
        }
    }
}
