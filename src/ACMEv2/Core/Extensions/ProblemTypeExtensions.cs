using CronBlocks.ACMEv2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Extensions
{
    internal static class ProblemTypeExtensions
    {
        public static string Description(this ProblemType problemType)
        {
            switch (problemType)
            {
                case ProblemType.Unknown: break;

                case ProblemType.AccountDoesnotExist:     break;
                case ProblemType.AlreadyRevoked:          break;
                case ProblemType.BadCSR:                  break;
                case ProblemType.BadNonce:                break;
                case ProblemType.BadRevocationReason:     break;
                case ProblemType.BadSignatureAlgorithm:   break;
                case ProblemType.Caa:                     break;
                case ProblemType.Compound:                break;
                case ProblemType.Connection:              break;
                case ProblemType.Dns:                     break;
                case ProblemType.ExternalAccountRequired: break;
                case ProblemType.IncorrectResponse:       break;
                case ProblemType.InvalidContact:          break;
                case ProblemType.Malformed:               break;
                case ProblemType.RateLimited:             break;
                case ProblemType.RejectedIdentifier:      break;
                case ProblemType.ServerInternal:          break;
                case ProblemType.Tls:                     break;
                case ProblemType.Unauthorized:            break;
                case ProblemType.UnsupportedContact:      break;
                case ProblemType.UnsupportedIdentifier:   break;
                case ProblemType.UserActionRequired:      break;
            }

            return "Unknown";
        }
    }
}
