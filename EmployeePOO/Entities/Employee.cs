using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePOO.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? EmployeeType { get; set; }

        public virtual void AddX()
        {
            Console.WriteLine("X");
        }
    }
}
