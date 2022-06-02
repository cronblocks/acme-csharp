using System;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Extensions
{
    internal static class Base64Extensions
    {
        public static string ConvertToBase64(this string data, bool removeTrailingEquals = true)
        {
            if (string.IsNullOrEmpty(data))
            {
                return "";
            }

            byte[] bytes = Encoding.UTF8.GetBytes(data);

            return ConvertToBase64(bytes, removeTrailingEquals);
        }

        public static string ConvertToBase64(this byte[] bytes, bool removeTrailingEquals = true)
        {
            if (bytes == null)
            {
                return "";
            }

            return ConvertToBase64(bytes, 0, bytes.Length, removeTrailingEquals);
        }

        public static string ConvertToBase64(this byte[] bytes, int start, int total, bool removeTrailingEquals = true)
        {
            if (bytes == null)
            {
                return "";
            }

            string b64 = Convert.ToBase64String(bytes, start, total, Base64FormattingOptions.None);

            return removeTrailingEquals ? b64.Replace("=", "") : b64;
        }

        public static string ConvertFromBase64(this string serializedBase64)
        {
            if (string.IsNullOrEmpty(serializedBase64))
            {
                return "";
            }

            return Encoding.UTF8.GetString(Convert.FromBase64String(serializedBase64));
        }
    }
}
