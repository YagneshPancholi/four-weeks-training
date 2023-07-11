using System;
namespace BankAccount
{
	abstract class BankAccount
	{
		public int AccountNumber;
		protected decimal Balance;
		
		public virtual void deposit(decimal amount)
		{
			Balance += amount;
		}
		public virtual void withdraw(decimal amount)
		{
			if (amount < Balance)
				Balance -= amount;
			else
				throw new Exception("Cannot withdraw");
		}
		public decimal getBalance()
		{
			return Balance;
		}
	}
	class SavingsAccount : BankAccount
	{
		public double interestRate;
		public SavingsAccount(int accNo , decimal bal , double ir)
		{
			this.AccountNumber = accNo;
			this.Balance = bal;
			this.interestRate = ir;
		}
		public decimal calculateInterestAmount(decimal balance)
		{
			//Console.WriteLine(interestRate);
			return balance * 30 * ((decimal)interestRate / 100) / 365;
		}
		public override void withdraw(decimal amount)
		{
			if (amount < Balance)
			{
				Balance -= amount;
				Console.WriteLine("Successfully withdrawn " + amount + " money!!!");
			}
			else
				Console.WriteLine("insufficiant fund!!!");
		}
		public override void deposit(decimal amount)
		{
			Balance += amount;
			Console.WriteLine("Successfully added " + amount + " money!!");
			Balance += calculateInterestAmount(Balance);
		}
	}
	class CheckingAccount : BankAccount
	{
		public decimal OverdraftLimit;
		public CheckingAccount(int accNo, decimal bal, decimal od)
		{
			this.AccountNumber = accNo;
			this.Balance = bal;
			this.OverdraftLimit = od; 
		}
	}
}