using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Entities
{
    public enum RevokeReason
    {
        Unspecified = 0,
        KeyCompromise,
        CaCompromise,
        AffiliationChanged,
        Superseded,
        CessationOfOperation,
        CertificateHold,
        
        _UNUSED,

        RemoveFromCrl,
        PrivilegeWithdrawn,
        AaCompromise
    }
}
