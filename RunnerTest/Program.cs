using System;

namespace RunnerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Parshad Cholera", 20);

            ba.Credit(5);
            ba.Debit(10);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}
