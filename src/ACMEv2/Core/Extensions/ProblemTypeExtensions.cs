using CronBlocks.ACMEv2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Extensions
{
    internal static class ProblemTypeExtensions
    {
        public static string GetProblemDescription(this ProblemType problemType)
        {
            switch (problemType)
            {
                case ProblemType.Unknown: break;

                case ProblemType.AccountDoesNotExist:     return "The request specified an account that does not exist";
                case ProblemType.AlreadyRevoked:          return "The request specified a certificate to be revoked that has already been revoked";
                case ProblemType.BadCSR:                  return "The CSR is unacceptable (e.g., due to a short key)";
                case ProblemType.BadNonce:                return "The client sent an unacceptable anti-replay nonce";
                case ProblemType.BadPublicKey:            return "The JWS was signed by a public key the server does not support";
                case ProblemType.BadRevocationReason:     return "The revocation reason provided is not allowed by the server";
                case ProblemType.BadSignatureAlgorithm:   return "The JWS was signed with an algorithm the server does not support";
                case ProblemType.Caa:                     return "Certification Authority Authorization (CAA) records forbid the CA from issuing a certificate";
                case ProblemType.Compound:                return "Specific error conditions are indicated in the \"subproblems\" array";
                case ProblemType.Connection:              return "The server could not connect to validation target";
                case ProblemType.Dns:                     return "There was a problem with a DNS query during identifier validation";
                case ProblemType.ExternalAccountRequired: return "The request must include a value for the \"externalAccountBinding\" field";
                case ProblemType.IncorrectResponse:       return "Response received didn't match the challenge's requirements";
                case ProblemType.InvalidContact:          return "A contact URL for an account was invalid";
                case ProblemType.InvalidEmail:            return "Let's Encrypt error - Contact for account was invalid";
                case ProblemType.Malformed:               return "The request message was malformed";
                case ProblemType.OrderNotReady:           return "The request attempted to finalize an order that is not ready to be finalized";
                case ProblemType.RateLimited:             return "The request exceeds a rate limit";
                case ProblemType.RejectedIdentifier:      return "The server will not issue certificates for the identifier";
                case ProblemType.ServerInternal:          return "The server experienced an internal error";
                case ProblemType.Tls:                     return "The server received a TLS error during validation";
                case ProblemType.Unauthorized:            return "The client lacks sufficient authorization";
                case ProblemType.UnsupportedContact:      return "A contact URL for an account used an unsupported protocol scheme";
                case ProblemType.UnsupportedIdentifier:   return "An identifier is of an unsupported type";
                case ProblemType.UserActionRequired:      return "Visit the \"instance\" URL and take actions specified there";
            }

            return "Unknown";
        }
        public static string GetProblemDescription(this string problemType)
        {
            problemType = problemType.Trim();
            switch (problemType)
            {
                case ProblemType.Unknown: break;

                case ProblemType.AccountDoesNotExist: return "The request specified an account that does not exist";
                case ProblemType.AlreadyRevoked: return "The request specified a certificate to be revoked that has already been revoked";
                case ProblemType.BadCSR: return "The CSR is unacceptable (e.g., due to a short key)";
                case ProblemType.BadNonce: return "The client sent an unacceptable anti-replay nonce";
                case ProblemType.BadPublicKey: return "The JWS was signed by a public key the server does not support";
                case ProblemType.BadRevocationReason: return "The revocation reason provided is not allowed by the server";
                case ProblemType.BadSignatureAlgorithm: return "The JWS was signed with an algorithm the server does not support";
                case ProblemType.Caa: return "Certification Authority Authorization (CAA) records forbid the CA from issuing a certificate";
                case ProblemType.Compound: return "Specific error conditions are indicated in the \"subproblems\" array";
                case ProblemType.Connection: return "The server could not connect to validation target";
                case ProblemType.Dns: return "There was a problem with a DNS query during identifier validation";
                case ProblemType.ExternalAccountRequired: return "The request must include a value for the \"externalAccountBinding\" field";
                case ProblemType.IncorrectResponse: return "Response received didn't match the challenge's requirements";
                case ProblemType.InvalidContact: return "A contact URL for an account was invalid";
                case ProblemType.InvalidEmail: return "Let's Encrypt error - Contact for account was invalid";
                case ProblemType.Malformed: return "The request message was malformed";
                case ProblemType.OrderNotReady: return "The request attempted to finalize an order that is not ready to be finalized";
                case ProblemType.RateLimited: return "The request exceeds a rate limit";
                case ProblemType.RejectedIdentifier: return "The server will not issue certificates for the identifier";
                case ProblemType.ServerInternal: return "The server experienced an internal error";
                case ProblemType.Tls: return "The server received a TLS error during validation";
                case ProblemType.Unauthorized: return "The client lacks sufficient authorization";
                case ProblemType.UnsupportedContact: return "A contact URL for an account used an unsupported protocol scheme";
                case ProblemType.UnsupportedIdentifier: return "An identifier is of an unsupported type";
                case ProblemType.UserActionRequired: return "Visit the \"instance\" URL and take actions specified there";
            }

            return "Unknown";
        }
    }
}
