using EmployeePOO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePOO.Interfaces
{
    public interface IEmployee
    {
        bool AddEmployee(Employee employee, List<Employee> listEmployees);

        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}
