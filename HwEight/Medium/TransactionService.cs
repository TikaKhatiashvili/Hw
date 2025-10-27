using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwEight.Medium;

public class TransactionService
{
    public void Transfer(BankAccount from, BankAccount to, decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Transfer amount must be positive.");

        try
        {
            from.Withdraw(amount);
            to.Deposit(amount);
            Console.WriteLine($"Transferred {amount:C} from {from.AccountNumber} to {to.AccountNumber}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($" Transfer failed: {ex.Message}");
        }
    }
}
