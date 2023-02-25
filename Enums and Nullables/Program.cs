namespace Enums_and_Nullables;
using Working_with_classes_structs_and_records;

public class Program
{
    public static void Main(string[] args)
    {
        Employee mondayShiftEmployee = new Employee("John", "Metone", 56)
        {
            DaysAvailable = ShiftDays.Monday
        };

        Console.WriteLine($"Employee: {mondayShiftEmployee.FirstName + " " + mondayShiftEmployee.LastName} works on {mondayShiftEmployee.DaysAvailable}."); 
    }
}