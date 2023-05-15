using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        private int _MoneyOnAccount = 0;

        public float GetMoneyOnAccount()
        {
            return _MoneyOnAccount;
        }

    }
}
