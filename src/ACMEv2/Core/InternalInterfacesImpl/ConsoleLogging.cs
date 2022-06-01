using CronBlocks.ACMEv2.Interface;

namespace CronBlocks.ACMEv2.Core.InternalInterfacesImpl
{
    internal class ConsoleLogging : IAcmeLogging
    {
        private bool logInfo = false;
        private bool logWarning = false;
        private bool logError = false;

        public ConsoleLogging(LoggingLevel level = LoggingLevel.Info)
        {
            SetLoggingLevel(level);
        }

        public void LogInfo(string message)
        {
            if (logInfo)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                System.Console.Write($"ACME - ");

                System.Console.ResetColor();
                System.Console.WriteLine($"{message}");
            }
        }

        public void LogWarning(string message)
        {
            if (logWarning)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write($"ACME Warning - ");
                
                System.Console.ResetColor();
                System.Console.WriteLine($"{message}");
            }
        }

        public void LogError(string message)
        {
            if (logError)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.Write($"ACME ERROR - ");

                System.Console.ResetColor();
                System.Console.WriteLine($"{message}");
            }
        }

        public void SetLoggingLevel(LoggingLevel level)
        {
            logInfo = false;
            logWarning = false;
            logError = false;

            switch (level)
            {
                case LoggingLevel.Info:
                    logInfo = true;
                    logWarning = true;
                    logError = true;
                    break;

                case LoggingLevel.Warning:
                    logInfo = false;
                    logWarning = true;
                    logError = true;
                    break;

                case LoggingLevel.Error:
                    logInfo = false;
                    logWarning = false;
                    logError = true;
                    break;
            }
        }
    }
}