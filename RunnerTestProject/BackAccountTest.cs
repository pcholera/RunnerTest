using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunnerTest;

namespace RunnerTestProject
{
    [TestClass]
    public class BackAccountTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double beginningBalance = 50;
            double debitAmount = 20;
            double expected = 30;

            BankAccount account = new BankAccount("Parshad Cholera", beginningBalance);
            account.Debit(debitAmount);
            Assert.AreEqual(expected, account.Balance, "Account not debited correctly");
        }

        [TestMethod]
        public void TestMethod2()
        {
            double beginningBalance = 50;
            double creditAmount = 20;
            double expected = 70;

            BankAccount account = new BankAccount("Parshad Cholera", beginningBalance);
            account.Credit(creditAmount);
            Assert.AreEqual(expected, account.Balance, "Account not debited correctly");
        }

        [TestMethod]
        public void TestMethod3()
        {
            double beginningBalance = 50;
            double debitAmount = 20;
            double creditAmount = 20;
            double expected = 50;

            BankAccount account = new BankAccount("Parshad Cholera", beginningBalance);
            account.Debit(debitAmount);
            account.Credit(creditAmount);
            Assert.AreEqual(expected, account.Balance, "Account not debited correctly");
        }

        [TestMethod]
        public void TestMethod4()
        {
            double beginningBalance = 50;
            double debitAmount = 20;
            double creditAmount = 20;
            double expected = 70;

            BankAccount account = new BankAccount("Parshad Cholera", beginningBalance);
            account.Debit(debitAmount);
            account.Credit(creditAmount);
            Assert.AreNotEqual(expected, account.Balance, "Account not debited correctly");
        }
    }
}
