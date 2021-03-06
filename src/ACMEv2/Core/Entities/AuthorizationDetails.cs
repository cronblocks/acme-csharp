namespace CronBlocks.ACMEv2.Core.Entities
{
    internal class AuthorizationDetails
    {
        public Identifier Identifier { get; set; }
        public string Status { get; set; }
        public string Expires { get; set; }
        public Challenge[] Challenges { get; set; }
        public bool? Wildcard { get; set; }
    }
}
