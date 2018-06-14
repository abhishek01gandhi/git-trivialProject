using System;
using BankApplication.Savings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBankApplication
{
    [TestClass]
    public class SavingsAccountYearUnitTest
    {
        [TestMethod]
        public void StartingBalance_Matches_Constructor()
        {
            Assert.AreEqual(10000, NewAccount().StartingBalance());
        }

        [TestMethod]
        public void InterestRate_Matches_Constructor()
        {
            Assert.AreEqual(10, NewAccount().InterestRate());
        }

        [TestMethod]
        public void EndingBalance_Applies_InterestRate()
        {
            Assert.AreEqual(11000, NewAccount().EndingBalance());
        }

        [TestMethod]
        public void TestNextYearsStartingBalance_Equals_ThisYearsEndingBalance()
        {
            SavingsAccountYear thisYear = NewAccount();
            Assert.AreEqual(thisYear.EndingBalance(), thisYear.NextYear().StartingBalance());
        }

        [TestMethod]
        public void TestNextYearsInterestRate_Equals_ThisYearsInterestRate()
        {
            SavingsAccountYear thisYear = NewAccount();
            Assert.AreEqual(thisYear.InterestRate(), thisYear.NextYear().InterestRate());
        }


        //Helper Methods

        private SavingsAccountYear NewAccount()
        {
            SavingsAccountYear account = new SavingsAccountYear(10000, 10);
            return account;
        }



    }
}
