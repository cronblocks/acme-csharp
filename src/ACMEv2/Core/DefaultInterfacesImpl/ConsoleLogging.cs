using CronBlocks.ACMEv2.Interface;

namespace CronBlocks.ACMEv2.Core.DefaultInterfacesImpl
{
    internal class ConsoleLogging : IAcmeLogging
    {
        private readonly bool logInfo;
        private readonly bool logWarning;
        private readonly bool logError;

        public ConsoleLogging(bool logInfo = false, bool logWarning = true, bool logError = true)
        {
            this.logInfo = logInfo;
            this.logWarning = logWarning;
            this.logError = logError;
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
    }
}