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
        
        Console.WriteLine($"First class point equals second class point: {classPoint == classPoint2}");

        classPoint2.YPoint = 20;
        classPoint2.XPoint = 20;
        
        Console.WriteLine($"First class point equals second class point after second class point modification: {classPoint == classPoint2}");

        //Comparing structs
        StructPoint structPoint1 = new StructPoint() { XPoint = 10, YPoint = 10 };
        StructPoint structPoint2 = structPoint1;
        StructPoint structPoint3 = new StructPoint() { XPoint = 20, YPoint = 20 };
        
        Console.WriteLine($"First struct point equals second struct point: {structPoint1 == structPoint2}");
        Console.WriteLine($"First struct point equals third struct point: {structPoint1 == structPoint3}");

        //Comparing records
        RecordPoint recordPoint1 = new RecordPoint() { XPoint = 10, YPoint = 10 };
        RecordPoint recordPoint2 = recordPoint1;

        RecordPoint recordPoint3 = new RecordPoint() { XPoint = 20, YPoint = 20 };
        
        Console.WriteLine($"First record point equals second record point: {recordPoint1 == recordPoint2}");
        Console.WriteLine($"First struct point equals third record point: {structPoint1 == structPoint3}");

    }
}

