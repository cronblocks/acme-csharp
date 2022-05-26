﻿namespace CronBlocks.ACMEv2.Core.Entities
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

        _UNUSED_REASON_,

        RemoveFromCrl,
        PrivilegeWithdrawn,
        AaCompromise
    }
}