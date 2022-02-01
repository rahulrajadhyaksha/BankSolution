using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException() : base("Balance Exception")
        {

        }

        public InsufficientBalanceException(string str) : base(str)
        {

        }
    }
}
