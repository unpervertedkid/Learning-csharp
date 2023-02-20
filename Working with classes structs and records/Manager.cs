namespace Working_with_classes_structs_and_records;

public class Manager:Employee,IPerson
{
    public Manager(string firstName, string lastName) : base(firstName, lastName)
    {}
    
    public int NumberOfDirectReports { get; set; }
}