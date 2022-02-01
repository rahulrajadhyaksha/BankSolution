using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class AccountNumberGenerator
    {
        int _lastAccountID;

        private static AccountNumberGenerator _instance = null;

        private AccountNumberGenerator()
        {
            _lastAccountID = 100;
        }

        public static AccountNumberGenerator Create()
        {

            if (_instance == null)
                _instance = new AccountNumberGenerator();
            return _instance;
        }

        public int NextAccountNumber
        {
            get
            {
                return ++_lastAccountID;
            }
        }

    }

}
