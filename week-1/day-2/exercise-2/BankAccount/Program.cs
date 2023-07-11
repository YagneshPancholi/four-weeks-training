﻿namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create SavingsAccount and CheckingAccount objects and perform operations
            SavingsAccount sa = new SavingsAccount(123,0,4);
            CheckingAccount ca = new CheckingAccount(124,0,1000);
            Console.WriteLine("Saving Account : ");
            Console.WriteLine(sa.getBalance());
            sa.withdraw(200);
            sa.deposit(500);
            Console.WriteLine(sa.getBalance());
            sa.withdraw(200);
            Console.WriteLine(sa.getBalance());
            
            Console.WriteLine("Checking Account : ");
            Console.WriteLine(ca.getBalance());
            ca.withdraw(200);
            ca.withdraw(800);
            ca.withdraw(10);
            Console.ReadLine();

        }
    }
}