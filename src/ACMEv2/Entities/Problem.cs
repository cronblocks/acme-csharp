namespace CronBlocks.ACMEv2.Entities
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
        Unknown = 0,

        AccountDoesnotExist,
        AlreadyRevoked,
        BadCSR,
        BadNonce,
        BadRevocationReason,
        BadSignatureAlgorithm,
        Caa,
        Compound,
        Connection,
        Dns,
        ExternalAccountRequired,
        IncorrectResponse,
        InvalidContact,
        Malformed,
        RateLimited,
        RejectedIdentifier,
        ServerInternal,
        Tls,
        Unauthorized,
        UnsupportedContact,
        UnsupportedIdentifier,
        UserActionRequired,
    }
}
