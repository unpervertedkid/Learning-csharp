using System.ComponentModel;

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
        
        static ShiftDays GetShiftDays(DayOfWeek day) => day switch
        {
            DayOfWeek.Monday => ShiftDays.Monday,
            DayOfWeek.Tuesday => ShiftDays.Tuesday,
            DayOfWeek.Wednesday => ShiftDays.Wednesday,
            DayOfWeek.Thursday => ShiftDays.Thursday,
            DayOfWeek.Friday => ShiftDays.Friday,
            DayOfWeek.Saturday => ShiftDays.Saturday,
            DayOfWeek.Sunday => ShiftDays.Sunday,
            _ => throw new InvalidEnumArgumentException("Invalid day provided!")
        };

        ShiftDays shiftDay = GetShiftDays(DateTime.Now.DayOfWeek);
        Console.WriteLine(shiftDay);
        
        //Using the is expression
        IPerson shiftWorker = new ShiftEmployee("Ilhan", "Marti") { StartDate = new DateOnly(2017, 09, 27) };
        IPerson manager = new Manager("John", "Baraza"){Level = 3};

        Console.WriteLine(GetEmployeeDetails(shiftWorker));        
        Console.WriteLine(GetEmployeeDetails(manager));        
    }

    static string GetEmployeeDetails(IPerson person)
    {
        if (person is ShiftEmployee shiftEmployee)
        {
            return ($"{shiftEmployee.FirstName + " " + shiftEmployee.LastName} start date: {shiftEmployee.StartDate}");
        }
        else if (person is Manager manager)
        {
            return ($"{manager.FirstName + " " + manager.LastName} is a level {manager.Level} manager.");  
        }
        else
        {
            return string.Empty;
        }
    }
}

