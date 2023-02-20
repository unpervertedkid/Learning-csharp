namespace Working_with_classes_structs_and_records;

public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}