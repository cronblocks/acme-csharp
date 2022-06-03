using CronBlocks.ACMEv2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Extensions
{
    internal static class ProblemTypeExtensions
    {
        public static string GetDescription(this ProblemType problemType)
        {
            switch (problemType)
            {
                case ProblemType.Unknown: break;

                case ProblemType.AccountDoesnotExist:     return "The request specified an account that does not exist";
                case ProblemType.AlreadyRevoked:          return "The request specified a certificate to be revoked that has already been revoked";
                case ProblemType.BadCSR:                  return "";
                case ProblemType.BadNonce:                return "";
                case ProblemType.BadRevocationReason:     return "";
                case ProblemType.BadSignatureAlgorithm:   return "";
                case ProblemType.Caa:                     return "";
                case ProblemType.Compound:                return "";
                case ProblemType.Connection:              return "";
                case ProblemType.Dns:                     return "";
                case ProblemType.ExternalAccountRequired: return "";
                case ProblemType.IncorrectResponse:       return "";
                case ProblemType.InvalidContact:          return "";
                case ProblemType.Malformed:               return "";
                case ProblemType.RateLimited:             return "";
                case ProblemType.RejectedIdentifier:      return "";
                case ProblemType.ServerInternal:          return "";
                case ProblemType.Tls:                     return "";
                case ProblemType.Unauthorized:            return "";
                case ProblemType.UnsupportedContact:      return "";
                case ProblemType.UnsupportedIdentifier:   return "";
                case ProblemType.UserActionRequired:      return "";
            }

            return "Unknown";
        }
    }
}
