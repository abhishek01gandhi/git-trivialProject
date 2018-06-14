using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Savings
{
    public class SavingsAccountYear
    {
        private int startingBalance = 0;
        private int interestRate = 0;

        public SavingsAccountYear(int startingBalance, int interestRate)
        {
            this.startingBalance = startingBalance;
            this.interestRate = interestRate;
        }
        public int StartingBalance()
        {
            return startingBalance;
        }

        public object InterestRate()
        {
            return interestRate;
        }

        public int EndingBalance()
        {
            return (StartingBalance() + (StartingBalance() * interestRate / 100));
        }

        public SavingsAccountYear NextYear()
        {
            return new SavingsAccountYear(this.EndingBalance(), interestRate);
        }
    }
}
