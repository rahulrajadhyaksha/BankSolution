using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class AccountFactory
    {
        static Hashtable _ht = new Hashtable();

        static AccountFactory()
        {
            _ht.Add("SA", typeof(BankLibrary.SavingAccount));
            _ht.Add("CA", typeof(BankLibrary.CurrentAccount));
        }

        public static Account Create(string typ, params object[] args)
        {
            Account act = null;
            Type t = _ht[typ] as Type;
            if (typ != null)
            {
                act = Activator.CreateInstance(t, args) as Account;
            }
            return act;
        }
    }

}
