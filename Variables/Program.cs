using Abstract_classes;

namespace Variables;

public class Program
{
    public static void Main(string[] args)
    {
        Account account = new CheckingAccount("Brian", "Silah", 2000);

        ((CheckingAccount)account).OverdrawFine = 5.0m;
        
        account.Withdraw(2500);
        
        Console.WriteLine($"The checking account balance: {account.Balance}");
    }
}