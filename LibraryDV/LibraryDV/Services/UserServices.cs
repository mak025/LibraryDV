using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
using LibraryDV.Repos;
using static LibraryDV.Models.User;

namespace LibraryDV.Services
/// Magnus Hansen
{
    /// <summary>
    /// Provides services for managing users in the library system.
    /// </summary>
    public class UserServices
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
        public void CreateEmployee(string name, string phoneNumber, string email, string password)
        {
            // Check for duplicates. ToList(); is being called to avoid iterating on the same collection while adding to it
            List<User> allUsers = _userInterface.GetAllUsers().ToList();

            bool duplicateExists = false;
            foreach (Employee user in allUsers)
            {
                duplicateExists =
                        user.PhoneNumber == phoneNumber || user.Email == email && user is Employee;
                Debug.WriteLine(duplicateExists);
            }
            if (duplicateExists == true)
            {
                Debug.WriteLine("Duplicate user found, no new user has been created");
            }
            else
            {
                Debug.WriteLine("No duplicate user found, creating new user");
                _userInterface.CreateEmployee(new Employee(name, phoneNumber, email, password));
            }
        }
        public void CreateAdmin(string name, string phoneNumber, string email, string password)
        {
            // Check for duplicates. ToList(); is being called to avoid iterating on the same collection while adding to it
            List<User> allUsers = _userInterface.GetAllUsers().ToList();

            bool duplicateExists = false;
            foreach (Admin user in allUsers)
            {
                duplicateExists =
                        user.PhoneNumber == phoneNumber || user.Email == email && user is Employee;
                Debug.WriteLine(duplicateExists);
            }
            if (duplicateExists == true)
            {
                Debug.WriteLine("Duplicate user found, no new user has been created");
            }
            else
            {
                Debug.WriteLine("No duplicate user found, creating new user");
                _userInterface.CreateEmployee(new Admin(name, phoneNumber, email, password));
            }
        }


        /// <summary>
        /// Retrieves a user by their unique identifier.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>The user with the specified ID, or null if not found.</returns>
        public User GetUserID(int id)
        {
            return _userInterface.GetUserByID(id);
        }

        /// <summary>
        /// Retrieves a user by their type.
        /// </summary>
        /// <param name="type">The type of user (e.g., "Customer", "Employee", "Admin").</param>
        /// <returns>The user with the specified type, or null if not found.</returns>
        public User GetUserType(string type)
        {
            return _userInterface.GetUserByType(type);
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
        /// <param name="userID">The user with updated information.</param>
        public void EditUser(int userID, string newName, string newPhoneNumber, string newEmail)
        {
            _userInterface.EditUser(userID, newName, newPhoneNumber, newEmail);
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