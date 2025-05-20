using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
/// Magnus Hansen
namespace LibraryDV.Repos
{
    /// <summary>
    /// Defines methods for managing users in the repository.
    /// </summary>
    interface IUserRepo
    {
        /// <summary>
        /// Adds a new user to the repository.
        /// </summary>
        /// <param name="user">The user to add.</param>
        void AddUser(User user);

        /// <summary>
        /// Retrieves a user by their unique identifier.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>The user with the specified ID, or null if not found.</returns>
        User GetUserID(int id);

        /// <summary>
        /// Retrieves a user by their type.
        /// </summary>
        /// <param name="type">The type of user (e.g., "Customer", "Employee", "Admin").</param>
        /// <returns>The user with the specified type, or null if not found.</returns>
        User GetUserType(string type);

        /// <summary>
        /// Retrieves all users from the repository.
        /// </summary>
        /// <returns>An enumerable collection of all users.</returns>
        IEnumerable<User> GetAllUsers();

        /// <summary>
        /// Updates the information of an existing user.
        /// </summary>
        /// <param name="user">The user with updated information.</param>
        void UpdateUser(User user);

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