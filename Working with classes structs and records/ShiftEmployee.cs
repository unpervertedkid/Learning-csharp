namespace Working_with_classes_structs_and_records;

public class ShiftEmployee:Employee
{
    public ShiftDays DaysAvailable { get; set; }

    public ShiftEmployee(string firstName, string lastName, int employeeId = 0,ShiftDays shiftDays = ShiftDays.Weekdays): base(firstName,lastName,employeeId)
    {
        
    }
}