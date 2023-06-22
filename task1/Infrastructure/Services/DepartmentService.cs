using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentService
{
    List<Department> departments;
    public DepartmentService()
    {
        departments = new List<Department>();
    }
    public List<Department> GetDepartments()
    {
        return departments;
    }
    public void AddDepartment(Department department){
        departments.Add(department);
    }

}