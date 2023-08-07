namespace AutomapperExample.Console;

public record EmployeeDto(int Id, string Name, string Email, double Salary, IEnumerable<DependentDto> Dependents) : BaseDto(Id, Name);