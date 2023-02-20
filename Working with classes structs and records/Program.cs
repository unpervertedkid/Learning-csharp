namespace Working_with_classes_structs_and_records;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("John", "Doe");
        Console.WriteLine($"Hello {employee.FirstName} {employee.LastName}!");
    }
}

