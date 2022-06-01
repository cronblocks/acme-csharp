namespace CronBlocks.ACMEv2.Interface
{
    public enum LoggingLevel
    {
        Info, Warning, Error
    }

    public interface IAcmeLogging
    {
        void SetLoggingLevel(LoggingLevel level);
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
