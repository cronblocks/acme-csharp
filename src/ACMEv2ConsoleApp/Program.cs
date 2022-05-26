using CronBlocks.ACMEv2.ExternalServices.CommandLine;

namespace CronBlocks.ACMEv2ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ACMEv2");
        Console.WriteLine("------------------");

        AcmeService acmeService = new AcmeService(new AcmeSettings()
        {
            // Settings will go here
        });

        acmeService.GetCertificate();

        Console.WriteLine();
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
    }
}