namespace CronBlocks.ACMEv2.Settings
{
    public class LetsEncryptSettings
    {
        public static readonly string Agreement = "https://letsencrypt.org/documents/LE-SA-v1.2-November-15-2017.pdf";
        public static readonly string ProblemTypeNamespace = "urn:ietf:params:acme:error:";
        public static readonly string Directory = "directory";
        public static readonly string NewNonce = "acme/new-nonce";
        public static readonly string NewAccount = "acme/new-acct";
        public static readonly string NewOrder = "acme/new-order";
        public static readonly string NewAuthz = "acme/new-authz";
        public static readonly string RevokeCert = "acme/revoke-cert";
        public static readonly string KeyChange = "acme/key-change";
    }
}
