using System;

namespace RunnerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Parshad Cholera", 30);

            ba.Credit(50);
            ba.Debit(20);//test
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
}
