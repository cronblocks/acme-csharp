namespace CronBlocks.ACMEv2.Core.Interfaces
{
    internal interface ISerializer
    {
        string SerializeToJson<T>(T obj);
        T DeserializeFromJson<T>(string json);
    }
}
