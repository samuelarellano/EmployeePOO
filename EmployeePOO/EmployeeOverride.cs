using EmployeePOO.Entities;
using EmployeePOO.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePOO
{
    public class EmployeeOverride : EmployeeCRUD
    {
        public override bool AddEmployee(Employee employee, List<Employee> listEmployees)
        {
            Console.WriteLine("Ya esta dado de alta");
            return true;
        }
    }
}
