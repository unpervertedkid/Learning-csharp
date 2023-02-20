namespace Working_with_classes_structs_and_records;

public struct Age
{
    public Age(DateTime birthDate)
    {
        BirthDate = birthDate;
        YearsOld = DateTime.Now.Year - birthDate.Year;
    }
    public DateTime BirthDate { get; set; }
    public int YearsOld { get; set; }
}