using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public abstract class User
    {
        public required string Name { get; set; }
        public required int ID { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
    }

    public class Employee : User
    {
        public required string password { get; set; }
        private bool _isAdmin = false;

    }

    public class Admin : Employee
    {
        private bool _isAdmin = true;
    }
}
