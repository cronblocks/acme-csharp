namespace CronBlocks.ACMEv2.Core.InternalInterfaces
{
    internal interface IServer
    {
        void ServeDataAtEndPoint(string endPoint, string data);
    }
}
