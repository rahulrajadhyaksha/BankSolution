using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class SavingAccount :
         Account, IInterest
    {
        public decimal MinimumBalance { get; set; }

        static SavingAccount()
        {

        }
        public SavingAccount()
        {
            MinimumBalance = 0.0m;
        }

        public SavingAccount(/*int aid,*/ string hn, decimal bal, decimal mbal = 2000)
            : base(/*aid,*/ hn, bal)
        {
            MinimumBalance = mbal;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine("from Saving");
            base.Deposit(amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (MinimumBalance > PBalance - amount)
            {
                //  Console.WriteLine("Insufficient Balance");
                throw new InsufficientBalanceException("Insufficient Balance");
            }
            else
                PBalance = PBalance - amount;
        }

        public decimal InterestRate(decimal rate)
        {
            return rate;
        }


        public override decimal CalculateBalanceWithInterest(decimal rate)
        {
            PBalance = PBalance + (PBalance * InterestRate(rate / 100));
            return PBalance;
        }
    }
}
