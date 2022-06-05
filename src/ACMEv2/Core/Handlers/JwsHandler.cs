﻿using System.Text.Json;

namespace CronBlocks.ACMEv2.Core.Handlers
{
    /// <summary>
    /// ACME Specific implementation is emphasized:
    /// 
    ///     A JWS object sent as the body of an ACME request MUST meet the
    /// following additional criteria:
    /// 
    ///     o  The JWS MUST be in the Flattened JSON Serialization [RFC7515]
    ///     o  The JWS MUST NOT have multiple signatures
    ///     o  The JWS Unencoded Payload Option [RFC7797] MUST NOT be used
    ///     o  The JWS Unprotected Header [RFC7515] MUST NOT be used
    ///     o  The JWS Payload MUST NOT be detached
    ///     o  The JWS Protected Header MUST include the following fields:
    ///     
    ///        *  "alg" (Algorithm)
    ///        
    ///           +  This field MUST NOT contain "none" or a Message Authentication
    ///              Code (MAC) algorithm (e.g.one in which the algorithm registry
    ///              description mentions MAC/HMAC)
    ///              
    ///        *  "nonce" (defined in Section 6.5)
    ///        *  "url" (defined in Section 6.4)
    ///        *  "jwk" (JSON Web Key) or "kid" (Key ID) - mutually exclusive.
    ///           
    ///           +  "jwk"
    ///           
    ///              -  For newAccount requests, and for revokeCert requests authenticated by
    ///                 a certificate key, there MUST be a "jwk" field. This field MUST contain the
    ///                 public key corresponding to the private key used to sign the JWS.
    ///                 
    ///           +  "kid"
    ///           
    ///              -  For all other requests, the request is signed using an existing account,
    ///                 and there MUST be a "kid" field. This field MUST contain the account URL
    ///                 received by POSTing to the newAccount resource.
    ///                 
    ///     o  An ACME server MUST implement the "ES256" signature algorithm [RFC7518]
    ///        and SHOULD implement the "EdDSA" signature algorithm using the "Ed25519"
    ///        variant (indicated by "crv") [RFC8037]
    /// </summary>
    internal class JwsHandler
    {
        public string SerializeToJson<T>(T obj)
        {
            if (obj == null)
            {
                return null;
            }

            return JsonSerializer.Serialize(obj);
        }

        public T DeserializeFromJson<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}