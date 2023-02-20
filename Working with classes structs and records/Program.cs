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
    }
}

