namespace CronBlocks.ACMEv2.Core.Entities
{
    public class Problem
    {
        public string StandardProblemTypeNamespace { get; set; }
        public ProblemType Type { get; set; }
        public string Detail { get; set; }
        public int? Status { get; set; }
    }

    public enum ProblemType
    {
        Unknown,
        AccountDoesnotExist,
        AlreadyRevoked,
        BadCSR,
        BadNonce,
        BadPublicKey,
        BadRevocationReason,
        BadSignatureAlgorithm,
        Caa,
        Compound,
        Connection,
        Dns,
        ExternalAccountRequired,
        IncorrectResponse,
        InvalidContact,
        InvalidEmail, // Let's encrypt difference: https://github.com/letsencrypt/boulder/blob/master/docs/acme-divergences.md
        Malformed,
        OrderNotReady,
        RateLimited,
        RejectedIdentifier,
        ServerInternal,
        Tls,
        Unauthorized,
        UnsupportedContact,
        UnsupportedIdentifier,
        UserActionRequired
    }
}
