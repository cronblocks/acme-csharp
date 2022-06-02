namespace CronBlocks.ACMEv2.Core.InternalInterfaces
{
    internal interface ISerializer
    {
        string SerializeToJson<T>(T obj);
        T DeserializeFromJson<T>(string json);

        string SerializeToBase64(string data, bool removeTrailingEquals = true);
        string SerializeToBase64(byte[] bytes, bool removeTrailingEquals = true);
        string SerializeToBase64(byte[] bytes, int start, int total, bool removeTrailingEquals = true);
        byte[] DeserializeFromBase64(string serializedBase64);
    }
}
