using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public class User
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
    }

    public class Employee : User
    {
        public required string EmployeeId { get; set; }
        public required string Department { get; set; }
        public required DateTime HireDate { get; set; }
        public required string Position { get; set; }
    }

    public class Admin : Employee
    {
        public required bool IsAdmin { get; set; }
    }
}
