using CronBlocks.ACMEv2.Interface;
using CronBlocks.ACMEv2.Interface.CommandLine;

namespace CronBlocks.ACMEv2ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ACMEv2");
        Console.WriteLine("------------------");

        CommandlineService acmeService = new CommandlineService(new AcmeSettings()
        {
            // Settings will go here
        });

        acmeService.GetCertificate(OnAcmeFailed, OnAcmeSucceeded);

        Console.WriteLine();
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
    }

    private static void OnAcmeSucceeded(string message, string certificateFilename)
    {
        throw new NotImplementedException();
    }

    private static void OnAcmeFailed(string message)
    {
        throw new NotImplementedException();
    }
}