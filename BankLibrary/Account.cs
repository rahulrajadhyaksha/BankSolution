using System;

namespace BankLibrary
{
    public delegate void BalanceChangeHandler(int aid, string hn,
         decimal bal, decimal change);
    public abstract class Account 
    {

        public event BalanceChangeHandler BalanceChange;
        //public int AccountID { get; set; }
        public int AccountID { get; }
        //public string HoldersName { get; set; }
        public string HoldersName { get; }
        //  public decimal  Balance { get; set; }

        private decimal _balance;

        private static int NextAccountID;

        public decimal Balance
        {
            get { return _balance; }
        }

        protected decimal PBalance
        {
            get { return _balance; }
            set { _balance = value; }
        }



        public object this[string str]
        {
            get
            {
                if (str.ToUpper() == "ACOUNTID")
                {
                    return AccountID;
                }
                if (str.ToUpper() == "HOLDERSNAME")
                {
                    return HoldersName;
                }
                if (str.ToUpper() == "BALANCE")
                {
                    return _balance;
                }

                return 0;

            }

        }

        static Account()
        {
            NextAccountID = 101;
        }
        public Account()
        {
            //AccountID = NextAccountID++;//101;
            AccountID = AccountNumberGenerator.Create().NextAccountNumber;
            HoldersName = "";
            _balance = 0.00m;
        }

        public Account(/*int aid,*/ string hn, decimal bal)
        {
            //AccountID = NextAccountID++;//aid;
            AccountID = AccountNumberGenerator.Create().NextAccountNumber;
            HoldersName = hn;
            _balance = bal;

        }

        public virtual void Deposit(decimal amount)
        {
            _balance += amount;
            if (BalanceChange != null)
                BalanceChange(AccountID, HoldersName, Balance, amount);
        }

        /*        public virtual void Withdraw(decimal amount)
                {
                    Balance -= amount;
                }
                */
        public abstract void Withdraw(decimal amount);
        public abstract decimal CalculateBalanceWithInterest(decimal rate);

        public override string ToString()
        {
            return String.Format("Account ID:{0}, HoldersName: {1}, Balance:{2} ", AccountID, HoldersName, Balance);
        }

        
    }
}
