namespace Abstract_classes;

public class SavingsAccount:Account

{   
    private const int FREE_WITHDRAWAL_LIMIT = 3;
    private const decimal WITHDRAWAL_LIMIT_FINE = 2.0m;
    private int numberOfWithdrawals = 0;
    public SavingsAccount(string firstName, string secondName, decimal initialBalance) : base(firstName, secondName, initialBalance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (!isFreeWithdrawalLimit())
        {
            base.DecrementBalance(WITHDRAWAL_LIMIT_FINE);
        }
        base.Withdraw(amount);
        numberOfWithdrawals++;
    }

    private bool isFreeWithdrawalLimit()
    {
        return numberOfWithdrawals < FREE_WITHDRAWAL_LIMIT;
    }
}