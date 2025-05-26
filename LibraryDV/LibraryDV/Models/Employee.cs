using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryDV.Models.User;

namespace LibraryDV.Models
{
    /// <summary>
    /// Represents an employee user.
    /// </summary>
    public class Employee : User
    {
        /// <summary>
        /// Gets or sets the employee's password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name of the employee.</param>
        /// <param name="id">The ID of the employee.</param>
        /// <param name="phoneNumber">The phone number of the employee.</param>
        /// <param name="email">The email address of the employee.</param>
        /// <param name="password">The password of the employee.</param>
        public Employee(string name, string phoneNumber, string email, string password) : base(name, phoneNumber, email)
        {
            Type = UserType.Employee;
            this.Password = password;
        }
    }
}
