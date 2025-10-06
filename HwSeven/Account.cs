using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwSeven;

public class Account
{
    private string _accountNumber;
    private string _currency;
    private decimal _balance;

    public string AccountNumber
    {
        get { return _accountNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 22)
                throw new ArgumentException("Account number must be exactly 22 characters.");
            _accountNumber = value;
        }
    }

    public string Currency
    {
        get { return _currency; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 3)
                throw new ArgumentException("Currency must be exactly 3 characters.");
            _currency = value.ToUpper();
        }
    }

    public decimal Balance
    {
        get { return _balance; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative.");
            _balance = value;
        }
    }
    public Account(string accountNumber, string currency, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Currency = currency;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        Balance += amount;
        Console.WriteLine($"{amount} {Currency} deposited. New balance: {Balance} {Currency}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");
        Balance -= amount;
        Console.WriteLine($"{amount} {Currency} withdrawn. New balance: {Balance} {Currency}");
    }

    public void Transfer(Account targetAccount, decimal amount)
    {
        if (targetAccount == null)
            throw new ArgumentNullException(nameof(targetAccount));
        if (Currency != targetAccount.Currency)
            throw new InvalidOperationException("Currency mismatch.");
        Withdraw(amount);
        targetAccount.Deposit(amount);
        Console.WriteLine($"{amount} {Currency} transferred to account {targetAccount.AccountNumber}.");
    }
}
