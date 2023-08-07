namespace AutomapperExample.Console;

public class Dependent
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Relationship { get; set; }
    public int EmployeeId { get; set; }

    public override string ToString() => $"Id: {Id}, Name: {Name}, Relationship: {Relationship}, EmployeeId: {EmployeeId}";
}
