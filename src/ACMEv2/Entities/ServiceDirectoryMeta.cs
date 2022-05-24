namespace CronBlocks.ACMEv2.Entities
{
    public class ServiceDirectoryMeta
    {
        public string TermsOfService { get; set; }
        public string Website { get; set; }
        public string[] CaaIdentities { get; set; }
        public string ExternalAccountRequired { get; set; }
    }
}
