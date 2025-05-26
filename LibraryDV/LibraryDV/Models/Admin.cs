using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
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
