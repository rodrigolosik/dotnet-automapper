namespace AutomapperExample.Console;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public double Salary { get; set; }
    public IEnumerable<Dependent>? Dependents { get; set; }

    public override string ToString()
    {
        var employee = $"Id: {Id}, Name: {Name}, Email: {Email}, Salary: {Salary}";

        if (Dependents is not null && Dependents.Any())
            foreach (var dependent in Dependents)
                employee += dependent.ToString();

        return employee;
    }
}
