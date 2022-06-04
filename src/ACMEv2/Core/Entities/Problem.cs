using System.Collections.Generic;

namespace CronBlocks.ACMEv2.Core.Entities
{
    public class Problem
    {
        public string StandardProblemTypeNamespace { get; set; }
        public string Type { get; set; }
        public string Detail { get; set; }
        public IEnumerable<Subproblem> Subproblems { get; set; }
        public int? Status { get; set; }
    }

    public class Subproblem
    {
        public string Type { get; set; }
        public string Detail { get; set; }
        public Identifier Identifier { get; set; }
    }

    public enum ProblemType
    {
        Unknown,
        AccountDoesNotExist,
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
        InvalidContact,                // Different for Let's Encrypt - Not Used
        InvalidEmail,                  // Additional for Let's Encrypt: https://github.com/letsencrypt/boulder/blob/master/docs/acme-divergences.md
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
