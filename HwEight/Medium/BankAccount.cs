using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwEight.Medium;

public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; protected set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public abstract void Withdraw(decimal amount);

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
    }

    public override string ToString()
    {
        return $"{GetType().Name} #{AccountNumber} | Balance: {Balance:C}";
    }
}

