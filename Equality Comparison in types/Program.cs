namespace Equality_Comparison;

public class Program
{
    public static void Main(string[] args)
    {
        //Comparing classes
        ClassPoint classPoint = new ClassPoint
        {
            XPoint = 10,
            YPoint = 10
        };

        ClassPoint classPoint2 = classPoint;
        
        Console.WriteLine($"First point equals second point: {classPoint == classPoint2}");
        
        
    }
}

