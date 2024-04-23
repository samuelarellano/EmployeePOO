using EmployeePOO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePOO.Validator
{
    public class EmployeeValidator
    {
        public bool ValidateEmployeeInformation(Employee employee)
        {
            if (employee == null) return false;
            else if (string.IsNullOrEmpty(employee.Name) || string.IsNullOrEmpty(employee.Description))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
