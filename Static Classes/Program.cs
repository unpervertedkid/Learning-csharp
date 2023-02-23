namespace Static_Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Database url:{DatabaseConfig.getDatabaseUrl()}");
    }
}