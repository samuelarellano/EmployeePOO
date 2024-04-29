using EmployeePOO.Entities;
using EmployeePOO.Exceptions;
using EmployeePOO.Interfaces;
using EmployeePOO.Messages;
using EmployeePOO.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePOO.Implementation
{
    public class EmployeeCRUD : Employee, IEmployee
    {
        public virtual bool AddEmployee(Employee employee, List<Employee>  listEmployees)
        {
            var validator = new EmployeeValidator();
            var isValid = validator.ValidateEmployeeInformation(employee);

            if(isValid)
            {
                Console.WriteLine($"Employee Information");
                Console.WriteLine($"{employee.Name} - {employee.Description}");
                listEmployees.Add(employee);
                return true;
            }
            else
            {
                throw new EmployeeAddException(MessagesApplication.ErrorAddEmployee);
            }
        }
        
        public virtual bool DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id, List<Employee> employees)
        {
           //Forma 1
           var employee = employees.Find(x => x.Id == id);

            return employee == null ? throw new EmployeeNotFoundException(MessagesApplication.EmployeeNotFound) : employee;

            //Forma 2
            //var employee = employees.Find(x => x.Id.Equals(id));
        }

        public bool UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
