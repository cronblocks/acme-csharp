namespace CronBlocks.ACMEv2.Core.Entities
{
    internal class ServiceDirectoryMeta
    {
        public string TermsOfService { get; set; }
        public string Website { get; set; }
        public string[] CaaIdentities { get; set; }
        public string ExternalAccountRequired { get; set; }
    }
}
