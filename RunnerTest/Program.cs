﻿using System;

namespace RunnerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Parshad Cholera", 20);

            ba.Credit(50);
            ba.Debit(10); //Release Change
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
}
