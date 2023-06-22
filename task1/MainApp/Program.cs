using Domain.Models;
using Infrastructure.Services;
var empService = new EmployeeService();
for (int i = 1; i <= 5; i++)
{
    var emp1 = new Employee();

    System.Console.WriteLine("Enter you Name");
    emp1.FirstName = Console.ReadLine();
    System.Console.WriteLine("Enter you Surname");
    emp1.LastName = Console.ReadLine();
    System.Console.WriteLine("Enter you Salary");
    emp1.Salary = Convert.ToInt32(Console.Read());
    System.Console.WriteLine("Enter you Date of Birth");
    emp1.BirthDate = new DateTime(Console.Read());
    var Department = new Department();

    System.Console.WriteLine("Enter you Departament");
    Department.Name = Console.ReadLine();
    Department.Description = Console.ReadLine();



    empService.AddEmployee(emp1);
}


// var emp2 = new Employee
// {
//     FirstName = "test",
//     LastName = "testov",
//     Salary = 15000,
//     BirthDate = new DateTime(2001, 10, 28),
//     Department = new Department
//     {
//         Name = "IT",
//         Description = "test"
//     }
// };



// empService.AddEmployee(emp1);
// empService.AddEmployee(emp2);

foreach (var employee in empService.GetEmployees())
{

    System.Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName} {employee.Salary} {employee.BirthDate.ToShortDateString()}");
    System.Console.WriteLine(employee.Department.Name + " " + employee.Department.Description);
    System.Console.WriteLine("--------------------------------");
}