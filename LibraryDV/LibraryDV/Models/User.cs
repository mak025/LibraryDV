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
        private static int _staticID = 1; // Static ID for unique user identification
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
    }
}
/// /Magnus Hansen
