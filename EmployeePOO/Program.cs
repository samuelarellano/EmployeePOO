// See https://aka.ms/new-console-template for more information


using EmployeePOO.Entities;
using EmployeePOO.Implementation;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

var option = string.Empty;

List<Employee> listEmployee = new List<Employee>();

while (option != "10")
{
    Console.WriteLine("Select option");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("10. Exit");
    option = Console.ReadLine();

    var employeeHelper = new EmployeeCRUD();

    switch (option)
    {
        case "1":
            employeeHelper.AddEmployee(AddEmployeeMessages(), listEmployee);
            break;
        case "10":
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

Employee AddEmployeeMessages()
{
    Console.WriteLine("Introduce name:");
    var name = Console.ReadLine();
    Console.WriteLine("Introduce description");
    var description= Console.ReadLine();
    Console.WriteLine("Are you Manager(1) or Admin(2)");
    Int32.TryParse(Console.ReadLine(),out int role);

    var idRandom = new Random();
    var id = idRandom.Next();

    Employee employee = new Employee
    {
        Description = description,
        EmployeeType = role,
        Name = name,
        Id = id
    };

    return employee;
}


