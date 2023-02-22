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
        
        //Comparing structs
        StructPoint structPoint1 = new StructPoint() { XPoint = 10, YPoint = 10 };
        StructPoint structPoint2 = structPoint1;
        
        Console.WriteLine($"First point equals second point: {structPoint1 == structPoint2}");

    }
}

