namespace Working_with_nullables;

public class Program
{
    public static void Main(string[] args)
    {
        string name = null;
        int? age = null;

        if (name != null)
        {
            Console.WriteLine($"Name is {name}");
        }

        if (age != null)
        {
            Console.WriteLine($"Age is {age}");
        }

        if (age.HasValue)
        {
            Console.WriteLine($"Age is {age.Value}");
        }
    }
}