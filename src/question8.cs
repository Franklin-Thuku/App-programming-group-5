/*
In a given bank, there are two types of bank accounts,
 namely Saving and Current. In both accounts, details 
 of account number, holder name and balance must be 
 kept. Both accounts have operations to check balance 
 and to deposit. The withdraw operation is in both 
 accounts but the conditions are different. In savings 
 account, the withdrawal is only possible if balance is
  more than the amount being withdrawn. For current 
  account, there is overdraft limit set for each client
  . Customers can withdraw beyond their balance but
cannot go beyond the overdraft. Only Savings account 
earns interest on balance at a rate determined by the 
bank at the end of calendar year.
Use C# programming language to implement the 
solution to the scenario.
*/

using System;

public abstract class BankAccount
{
    public string AccountNumber { get; }
    public string HolderName { get; }
    public double Balance { get; private set; }

    protected BankAccount(string accountNumber, string holderName, double balance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public abstract bool Withdraw(double amount);
}

public class SavingsAccount : BankAccount
{
    private double interestRate;

    public SavingsAccount(string accountNumber, string holderName, double balance, double interestRate) : base(accountNumber, holderName, balance)
    {
        this.interestRate = interestRate;
    }

    public override bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }

    public void AddInterest()
    {
        Balance += Balance * interestRate;
    }
}

public class CurrentAccount : BankAccount
{
    private double overdraftLimit;

    public CurrentAccount(string accountNumber, string holderName, double balance, double overdraftLimit) : base(accountNumber, holderName, balance)
    {
        this.overdraftLimit = overdraftLimit;
    }

    public override bool Withdraw(double amount)
    {
        if (Balance + overdraftLimit >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}