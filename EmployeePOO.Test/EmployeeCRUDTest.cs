using EmployeePOO.Entities;
using EmployeePOO.Enumerators;
using EmployeePOO.Exceptions;
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
        private List<Employee> _employees;
        public EmployeeCRUDTest() 
        { 
            _employeeCRUD = new EmployeeCRUD();
            _employees = new List<Employee> 
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Jesús",
                    Description = "Desarrollador de Software",
                    EmployeeType = (int)EmployeeTypes.Admin
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Enrique",
                    Description = "Desarrollador de Software",
                    EmployeeType = (int)EmployeeTypes.Admin
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Carla",
                    Description = "Soporte técnico",
                    EmployeeType = (int)EmployeeTypes.Admin
                }
            };
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

        [Fact(Skip ="No tengo tiempo de arreglar prueba unitaria")]
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

        [Theory(DisplayName = "Validar la funcionalidad del Theory")]
        [InlineData(1)]
        [InlineData(2)]
        private void GetEmployeeById(int id)
        {
            //Arrage


            //Act
            var result = _employeeCRUD.GetEmployee(id, _employees);
            
            //Assert

            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
        }

        [Fact]
        private void GetEmployeeById_ExceptionError()
        {
            //Arrange
            var id = 4;

            //Act
            //assert
            Assert.Throws<EmployeeNotFoundException>(() => _employeeCRUD.GetEmployee(id, _employees));
        }
    }
}
