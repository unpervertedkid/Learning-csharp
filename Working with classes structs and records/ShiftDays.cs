namespace Working_with_classes_structs_and_records;
[Flags]
public enum ShiftDays
{
    Sunday = 1,
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Weekdays = 63,
    Saturday = 64,
    Weekend = 65
    
}