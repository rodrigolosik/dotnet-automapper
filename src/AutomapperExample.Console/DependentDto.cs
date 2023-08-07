namespace AutomapperExample.Console;

public record DependentDto(int Id, string Name, string Relationship, int EmployeeId) : BaseDto(Id, Name);