using System.Diagnostics.CodeAnalysis;

namespace Working_with_nullables;

public class Program
{
    public static void Main(string[] args)
    {
        string? name = null;
        int? age = null;

        int definitiveInt = age ?? 17;
        Console.WriteLine($"Definitive int: {definitiveInt}");
            
        age = 5;
        definitiveInt = age ?? 17;
        Console.WriteLine($"Definitive int: {definitiveInt}");

        definitiveInt = age != null ? age.Value : 17;
        Console.WriteLine($"Definitive int: {definitiveInt}");

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

        Console.WriteLine(TrimAndPad(name,20,'-'));
    }

    private static string TrimAndPad([AllowNull] string input, int length, char padChar)
    {
        if (input == null)
        {
            return String.Empty.PadLeft(length, padChar);
        }
        else
        {
            return input.Trim().PadLeft(length, padChar);
        }
         
    }
}