namespace CronBlocks.ACMEv2.Interface
{
    public interface IAcmeLogging
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
