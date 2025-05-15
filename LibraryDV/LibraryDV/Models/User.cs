using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{   /// Magnus Hansen
    /// <summary>
    /// Abstract base class representing a user.
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Gets or sets the user's name.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the user's ID.
        /// </summary>
        public required int ID { get; set; }

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
    /// Represents an employee user.
    /// </summary>
    public class Employee : User
    {
        /// <summary>
        /// Gets or sets the employee's password.
        /// </summary>
        public required string password { get; set; }

        private bool _isAdmin = false;
    }

    /// <summary>
    /// Represents an admin user.
    /// </summary>
    public class Admin : Employee
    {
        private bool _isAdmin = true;
    }
}
    /// /Magnus Hansen
