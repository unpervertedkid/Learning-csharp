namespace Working_with_classes_structs_and_records;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("John", "Doe")
        {
            Age = new Age(new DateTime(2001,10,1)),
            Id = 1,
            StartDate = new DateOnly(2021, 10, 1),
            ShiftStartTime = new TimeOnly(8, 0, 0)
        };
        
        Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} started working on {employee.StartDate} and his/her shift starts at {employee.ShiftStartTime}.");
        
        Manager level2Manager = new Manager()
        {
            FirstName = "Jane",
            LastName = "Doe",
            Age = new Age(new DateTime(2001, 10, 1)),
            Id = 2,
            StartDate = new DateOnly(2021, 10, 1),
            ShiftStartTime = new TimeOnly(8, 0, 0),
            Level = 2
        };
        
        Console.WriteLine($"Manager {level2Manager.FirstName} {level2Manager.LastName}, level:{level2Manager.Level} started working on {level2Manager.StartDate} and his/her shift starts at {level2Manager.ShiftStartTime}.");
        level2Manager.SetNumberOfDirectReports(27);
        Console.WriteLine($"Manager {level2Manager.FirstName} {level2Manager.LastName} has {level2Manager.NumberOfDirectReports} direct reports.");
    }
}

