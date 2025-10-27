namespace HwEight.Medium;

public class LoanAccount : BankAccount
{
    public LoanAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance) { }

    public override void Withdraw(decimal amount)
    {
        throw new InvalidOperationException("Withdrawals are not allowed from a Loan Account.");
    }

    public override void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Payment amount must be positive.");

        Balance -= amount;
    }
}
