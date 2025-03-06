using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    protected double balance;
    public virtual void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }
}
class SavingsAccount : BankAccount
{
    private double interestRate = 0.05;
    public override void Deposit(double amount)
    {
        balance += amount + (amount * interestRate);
        Console.WriteLine($"Deposited with interest: {amount * interestRate}");
    }
}
