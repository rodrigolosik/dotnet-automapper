using AutoMapper;
using AutomapperExample.Console;

var dependentDto = new DependentDto(1, "Eric Libanio", "Son", 1);

var employeeDto = new EmployeeDto(1, "Rodrigo Losik", "rodrigo@teste.com", 1000F, new List<DependentDto>() { dependentDto });

var employee = GetEmployeeFromDto(employeeDto);

Console.WriteLine(employee.ToString());

static Employee GetEmployeeFromDto(EmployeeDto dto)
{
    var mapperConfiguration = new MapperConfiguration(config =>
    {
        config.CreateMap<EmployeeDto, Employee>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name.ToUpper()));

        config.CreateMap<DependentDto, Dependent>();
    });

    mapperConfiguration.AssertConfigurationIsValid();

    var mapper = new Mapper(mapperConfiguration);

    var employee = mapper.Map<Employee>(dto);

    return employee;
}
