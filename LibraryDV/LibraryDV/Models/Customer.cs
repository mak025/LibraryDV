using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
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
}
