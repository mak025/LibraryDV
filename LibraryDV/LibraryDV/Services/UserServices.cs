using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
using LibraryDV.Repos;

namespace LibraryDV.Services
/// Magnus Hansen
{
    /// <summary>
    /// Provides services for managing users in the library system.
    /// </summary>
    class UserServices
    {
        private IUserRepo _userInterface;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserServices"/> class.
        /// </summary>
        /// <param name="userInterface">The user repository interface.</param>
        public UserServices(IUserRepo userInterface)
        {
            _userInterface = userInterface;
        }

        /// <summary>
        /// Adds a new user to the repository.
        /// </summary>
        /// <param name="user">The user to add.</param>
        public void AddUser(User user)
        {
            _userInterface.AddUser(user);
            //checks if user already exists by Email
            //Checks the list of users in the repository to see if the email already exists
            if (_userInterface.GetAllUsers().Any(u => u.Email == user.Email))
            {
                Console.WriteLine("User already exists.");
            }
            else
            {
                _userInterface.AddUser(user);
                Console.WriteLine("User added successfully.");
            }

        }

        /// <summary>
        /// Retrieves a user by their unique identifier.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>The user with the specified ID, or null if not found.</returns>
        public User GetUserID(int id)
        {
            return _userInterface.GetUserID(id);
        }

        /// <summary>
        /// Retrieves a user by their type.
        /// </summary>
        /// <param name="type">The type of user (e.g., "Customer", "Employee", "Admin").</param>
        /// <returns>The user with the specified type, or null if not found.</returns>
        public User GetUserType(string type)
        {
            return _userInterface.GetUserType(type);
        }

        /// <summary>
        /// Retrieves all users from the repository.
        /// </summary>
        /// <returns>An enumerable collection of all users.</returns>
        public IEnumerable<User> GetAllUsers()
        {
            return _userInterface.GetAllUsers();
        }

        /// <summary>
        /// Updates the information of an existing user.
        /// </summary>
        /// <param name="user">The user with updated information.</param>
        public void UpdateUser(User user)
        {
            _userInterface.UpdateUser(user);
        }

        /// <summary>
        /// Deletes a user from the repository by their unique identifier.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        public void DeleteUser(int id)
        {
            _userInterface.DeleteUser(id);
        }

        /// <summary>
        /// Displays or retrieves detailed information about a user.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        public void GetUserDetails(int id)
        {
            _userInterface.GetUserDetails(id);
        }
    }
}
/// Magnus Hansen