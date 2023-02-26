namespace Working_with_classes_structs_and_records;

public class Manager:Employee
{
    public Manager()
    {}
    public Manager(string? firstName, string? lastName) : base(firstName, lastName)
    {}
    
    public int NumberOfDirectReports { get; private set; }
    public int Level { get; init; }
    
    public void SetNumberOfDirectReports(int numberOfDirectReports)
    {
        NumberOfDirectReports = numberOfDirectReports;
    }
}