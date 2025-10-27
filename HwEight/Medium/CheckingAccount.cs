namespace HwEight.Medium;

public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance) { }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdraw amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds for withdrawal.");

        Balance -= amount;
    }
}
