namespace Working_with_classes_structs_and_records;

public class Employee:IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int id { get; set; }
    public Age Age { get; set; }
    
    public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
}