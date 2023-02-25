namespace Enums_and_Nullables;
using Working_with_classes_structs_and_records;

public class Program
{
    public static void Main(string[] args)
    {
        ShiftEmployee shiftEmployee = new ShiftEmployee("John", "Metone", 56)
        {
            DaysAvailable = ShiftDays.Weekdays | ShiftDays.Weekend
        };

        Console.WriteLine($"Employee: {shiftEmployee.FirstName + " " + shiftEmployee.LastName} works on {shiftEmployee.DaysAvailable}."); 
    }
}