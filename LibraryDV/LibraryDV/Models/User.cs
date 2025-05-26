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
        /// Static variable to keep track of the next unique user ID.
        /// </summary>
        private static int _staticID = 1; // Static ID for unique user identification

        /// <summary>
        /// enum UserType is only used in UserJsonConverter.cs for deserialization purposes.
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
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user's ID.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the user's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        public string Email { get; set; }
        public User(string name, string phoneNumber, string email)
        {
            UserID = _staticID++;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
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
            public Customer(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
            {
                Type = UserType.Customer;
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
            public Admin(string name, string phoneNumber, string email, string password)
                : base(name, phoneNumber, email, password)
            {
                this.Password = password;
                Type = UserType.Admin;
            }
        }
    }
}
/// /Magnus Hansen
