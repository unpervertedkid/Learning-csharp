namespace Abstract_classes;

public class CheckingAccount:Account
{
    public  decimal OverdrawFine { get; set; }
    public CheckingAccount(string firstName, string secondName, decimal initialBalance) : base(firstName, secondName, initialBalance)
    {
        OverdrawFine = 10.0m;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
          DecrementBalance(amount);
          DecrementBalance(OverdrawFine);
        }
        else
        {
            base.Withdraw(amount);
        }
    }
}