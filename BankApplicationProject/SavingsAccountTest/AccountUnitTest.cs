using BankApplication.Savings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBankApplication
{
    [TestClass]
    public class AccountUnitTest
    {
        Account account = new Account();

        [TestMethod][Priority(0)][TestCategory("Happy Path")]
        public void TestAccountStatus_Active_Success()
        {
            Assert.IsTrue(account.IsAccountActive("1234"), "Failed, Account is not Active");
        }

        [TestMethod]
        [Priority(0)]
        [TestCategory("Sad Path")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAccountStatus_ArgumentException_Success()
        {
            account.IsAccountActive(null);
        }

        [TestMethod]
        [Priority(0)]
        [TestCategory("Sad Path")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAccountStatus_AccountNumberWhiteSpace_ArgumentException_Success()
        {
            account.IsAccountActive(" ");
        }

    }
}
