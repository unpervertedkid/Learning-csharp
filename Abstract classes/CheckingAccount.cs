namespace Abstract_classes;

public class CheckingAccount:Account
{
    private const decimal OVERDRAW_FINE = 10.0m;
    public CheckingAccount(string firstName, string secondName, decimal initialBalance) : base(firstName, secondName, initialBalance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
          DecrementBalance(amount);
          DecrementBalance(OVERDRAW_FINE);
        }
        else
        {
            base.Withdraw(amount);
        }
    }
}