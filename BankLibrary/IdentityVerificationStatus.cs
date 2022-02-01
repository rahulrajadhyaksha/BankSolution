
using System.Collections.Generic;

namespace BankLibrary
{
    public class IdentityVerificationStatus : ValueObject
    {
        public bool Passed { get; }
        
        private IdentityVerificationStatus(){}

        public IdentityVerificationStatus(bool identityVerified)
        {
            Passed = identityVerified;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Passed;
        }
    }
}