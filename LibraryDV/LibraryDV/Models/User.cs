using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
    /// Magnus Hansen
{
    /// <summary>
    /// Represents a user in the library system.
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Specifies the type of user.
        /// </summary>
        public enum UserType
        {
            /// <summary>
            /// A customer user.
            /// </summary>
            Customer,    // 0
            /// <summary>
            /// An employee user.
            /// </summary>
            Employee,    // 1
            /// <summary>
            /// An admin user.
            /// </summary>
            Admin,   // 2
        }

        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        public UserType Type { get; set; }

        /// <summary>
        /// Gets or sets the user's name.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the user's ID.
        /// </summary>
        public required int UserID { get; set; }

        /// <summary>
        /// Gets or sets the user's phone number.
        /// </summary>
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        public required string Email { get; set; }
    }

    /// <summary>
    /// Represents a customer user.
    /// </summary>
    public class Customer : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">The name of the customer.</param>
        /// <param name="id">The ID of the customer.</param>
        /// <param name="phoneNumber">The phone number of the customer.</param>
        /// <param name="email">The email address of the customer.</param>
        public Customer(string name, int id, string phoneNumber, string email)
        {
            Type = UserType.Customer;
            Name = name;
            UserID = id;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    /// <summary>
    /// Represents an employee user.
    /// </summary>
    public class Employee : User
    {
        /// <summary>
        /// Gets or sets the employee's password.
        /// </summary>
        public required string password { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name of the employee.</param>
        /// <param name="id">The ID of the employee.</param>
        /// <param name="phoneNumber">The phone number of the employee.</param>
        /// <param name="email">The email address of the employee.</param>
        /// <param name="password">The password of the employee.</param>
        public Employee(string name, int id, string phoneNumber, string email, string password)
        {
            Type = UserType.Employee;
            Name = name;
            UserID = id;
            PhoneNumber = phoneNumber;
            Email = email;
            this.password = password;
        }
    }


    /// <summary>
    /// Represents an admin user.
    /// </summary>
    public class Admin : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Admin"/> class.
        /// </summary>
        /// <param name="name">The name of the admin.</param>
        /// <param name="id">The ID of the admin.</param>
        /// <param name="phoneNumber">The phone number of the admin.</param>
        /// <param name="email">The email address of the admin.</param>
        /// <param name="password">The password of the admin.</param>
        public Admin(string name, int id, string phoneNumber, string email, string password)
            : base(name, id, phoneNumber, email, password)
        {
            Type = UserType.Admin;
        }
    }
}
    /// /Magnus Hansen
