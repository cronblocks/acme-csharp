namespace CronBlocks.ACMEv2.Core.Interfaces
{
    internal interface IServer
    {
        void ServeDataAtEndPoint(string endPoint, string data);
    }
}
