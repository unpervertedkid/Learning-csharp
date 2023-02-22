namespace Abstract_classes;

public class Program
{
    public static void Main(string[] args)
    {
        Account checkingAccount = new CheckingAccount("Ilhan","Ibrahim",2000);
        Account savingsAccount = new SavingsAccount("Brian","Silah",2000);
        
        Console.WriteLine($"Checking account balance:{checkingAccount.Balance}");
        Console.WriteLine($"Saving account balance:{savingsAccount.Balance}");
        
        checkingAccount.Withdraw(100);
        savingsAccount.Withdraw(100);
        
        Console.WriteLine($"Checking account balance:{checkingAccount.Balance}");
        Console.WriteLine($"Saving account balance:{savingsAccount.Balance}");
        
        //Try to withdraw more than three times from the savings account
        savingsAccount.Withdraw(10);
        savingsAccount.Withdraw(10);
        savingsAccount.Withdraw(10);
        
        Console.WriteLine($"Saving account balance:{savingsAccount.Balance}");
        
        //Try to overdraw the checking account
        checkingAccount.Withdraw(3000);
        
        Console.WriteLine($"Checking account balance:{checkingAccount.Balance}");

    }
}

