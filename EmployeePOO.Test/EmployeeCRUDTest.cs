using EmployeePOO.Entities;
using EmployeePOO.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePOO.Test
{
    public class EmployeeCRUDTest
    {
        private EmployeeCRUD _employeeCRUD;

        public EmployeeCRUDTest() 
        { 
            _employeeCRUD = new EmployeeCRUD();
        }

        [Fact(DisplayName = "Unit test for add employee with return true")]
        public void AddEmployee_ReturnTrue()
        {
            // Arrange
            //EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            
            //Dummy Data
            var employeeRequest = new Employee
            {
                Description = "Developer",
                EmployeeType = 1,
                Id = 1,
                Name = "Samuel",
            };

            //Act
            var employeeResult = _employeeCRUD.AddEmployee(employeeRequest,new List<Employee>());

            //Assert
            Assert.True(employeeResult);
        }

        [Fact]
        public void AddEmployee_ReturnFalse() 
        {
            //Arrange
            //EmployeeCRUD employeeCRUD = new EmployeeCRUD();

            //Dummy Data
            var employeeRequest = new Employee
            {
                Description = string.Empty,
                EmployeeType = 1,
                Id = 1,
                Name = "Carlos",
            };

            //Act
            var result = _employeeCRUD.AddEmployee(employeeRequest, new List<Employee>());

            //Assert
            Assert.False(result);
        }
    }
}
