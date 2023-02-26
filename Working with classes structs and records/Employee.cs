namespace Working_with_classes_structs_and_records;

public class Employee:IPerson
{
    public Employee()
    {}
    public Employee(string? firstName, string? lastName, int employeeId = 0)
    {
        FirstName = firstName;
        LastName = lastName;
        EmployeeId = employeeId;
    }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
    
    
    public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
}

