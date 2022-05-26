namespace CronBlocks.ACMEv2.Core.Interfaces
{
    internal interface ISerializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string json);
    }
}
