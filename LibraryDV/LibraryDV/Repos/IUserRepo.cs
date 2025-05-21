using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
using static LibraryDV.Models.User;
/// Magnus Hansen
namespace LibraryDV.Repos
{
    /// <summary>
    /// Defines methods for managing users in the repository.
    /// </summary>
    public interface IUserRepo
    {
        void CreateEmployee(Employee employee);

        void CreateAdmin(Admin admin);
        /// <summary>
        /// Retrieves a user by their unique identifier.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>The user with the specified ID, or null if not found.</returns>
        User GetUserByID(int id);

        /// <summary>
        /// Retrieves a user by their type.
        /// </summary>
        /// <param name="type">The type of user (e.g., "Customer", "Employee", "Admin").</param>
        /// <returns>The user with the specified type, or null if not found.</returns>
        User GetUserByType(string type);

        /// <summary>
        /// Retrieves all users from the repository.
        /// </summary>
        /// <returns>An enumerable collection of all users.</returns>
        IEnumerable<User> GetAllUsers();

        /// <summary>
        /// Updates the information of an existing user.
        /// </summary>
        /// <param name="userID">The user with updated information.</param>
        void EditUser(int userID, string newName, string newPhoneNumber, string newEmail);

        /// <summary>
        /// Deletes a user from the repository by their unique identifier.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        void DeleteUser(int id);

        /// <summary>
        /// Displays or retrieves detailed information about a user.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        void GetUserDetails(int id);
    }
}
/// /Magnus Hansen