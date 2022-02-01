using System;

namespace BankLibrary
{
    public class CreditScoreResultArgs : EventArgs
    {
        public int Score { get; set; }        
    }
}