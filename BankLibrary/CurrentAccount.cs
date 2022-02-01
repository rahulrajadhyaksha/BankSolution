using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class CurrentAccount
                                : Account, IInterest
    {
        public decimal OverdraftLimit { get; set; }

        static CurrentAccount()
        {

        }
        public CurrentAccount()
        {
            OverdraftLimit = 0.0m;
        }

        public CurrentAccount(/*int aid,*/ string hn, decimal bal, decimal od = 5000)
            : base(/*aid,*/ hn, bal)
        {
            OverdraftLimit = od;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine("from Current");
            base.Deposit(amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (PBalance - OverdraftLimit < amount)
            {
                // Console.WriteLine("Insufficient Balance");
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
