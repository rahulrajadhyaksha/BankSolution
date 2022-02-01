using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public interface IInterest
    {
        decimal InterestRate(decimal rate);
    }
}
