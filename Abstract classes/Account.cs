using Microsoft.CSharp.RuntimeBinder;

namespace Abstract_classes;

public abstract class Account
{
    public Account(string firstName, string secondName, decimal initialBalance)
    {
        FirstName = firstName;
        SecondName = secondName;
        Balance = initialBalance;
    }
    public string FirstName { set; get; }
    public string SecondName { set; get; }
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        IncrementBalance(amount);
    }

    public virtual void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new RuntimeBinderException(
                $"The balance:{Balance} is less than amount you want to withdraw:{amount}");
        }

        DecrementBalance(amount);
    }

    protected void DecrementBalance(decimal amount)
    {
        Balance -= amount;
    }

    private void IncrementBalance(decimal amount)
    {
        Balance += amount;
    }
}