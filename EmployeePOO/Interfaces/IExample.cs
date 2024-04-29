using EmployeePOO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePOO.Interfaces
{
    internal class IExample : IEmployee
    {
        public bool AddEmployee(Employee employee, List<Employee> listEmployees)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id, List<Employee> listEmployees)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
