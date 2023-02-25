namespace Enums_and_Nullables;
using Working_with_classes_structs_and_records;

public class Program
{
    public static void Main(string[] args)
    {
        var shiftDayAvailable = Enum.GetNames(typeof(ShiftDays));
        Console.WriteLine($"The shift days available are: {String.Join(',',shiftDayAvailable)}.");

        ShiftEmployee[] shiftEmployees = InitializeEmployees();
        PrintEmployees(shiftEmployees);
    }

    private static void PrintEmployees(ShiftEmployee[] shiftEmployees)
    {
        foreach (ShiftEmployee shiftEmployee in shiftEmployees)
        {
            if (IsFullTimeEmployee(shiftEmployee))
            {
                Console.WriteLine($"Employee: {shiftEmployee.FirstName + " " + shiftEmployee.LastName} is a full time worker.");
            }
            else
            {
                Console.WriteLine($"Employee: {shiftEmployee.FirstName + " " + shiftEmployee.LastName} is not a full time worker.");
            }

            Console.WriteLine($"The employee works on: {shiftEmployee.DaysAvailable}");
        }
    }

    private static ShiftEmployee[] InitializeEmployees()
    {
        ShiftEmployee shiftEmployee1 = new ShiftEmployee("John", "Metone", 56)
        {
            DaysAvailable = ShiftDays.Weekdays | ShiftDays.Weekend
        };
        ShiftEmployee shiftEmployee2 = new ShiftEmployee("Lucy", "Celina")
        {
            DaysAvailable = ShiftDays.Weekend
        };
        ShiftEmployee shiftEmployee3 = new ShiftEmployee("Sebastian", "Christian");
        

        ShiftEmployee[] shiftEmployees = {shiftEmployee1,shiftEmployee2,shiftEmployee3 };
        return shiftEmployees;
    }

    private static bool IsFullTimeEmployee(ShiftEmployee shiftEmployee)
    {
        return shiftEmployee.DaysAvailable.HasFlag(ShiftDays.Weekdays) &
               shiftEmployee.DaysAvailable.HasFlag(ShiftDays.Weekend);
    }
}