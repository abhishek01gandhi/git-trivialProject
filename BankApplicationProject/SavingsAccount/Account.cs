using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Savings
{
    public class Account
    {
        private int balance = 0;
        private bool accountStatus = false;
        private int interestRate = 0;

        public bool IsAccountActive(string accNumber)
        {
            if (String.IsNullOrWhiteSpace(accNumber))
            {
                throw new ArgumentException("Account number Can't be Null");
            }
            else
            {
                accountStatus = true;
            }
            return accountStatus;
        }

    }
}
