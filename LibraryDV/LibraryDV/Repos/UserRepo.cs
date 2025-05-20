using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibraryDV.Models;
using static LibraryDV.Models.User;


namespace LibraryDV.Repos

/// Magnus Hansen
{
    /// <summary>
    /// Repository for managing users in the library system.
    /// </summary>
    public class UserRepo : IUserRepo
    {
        /// <summary>
        /// List to store users.
        /// </summary>
        private List<User> _users = new List<User>();
        private readonly string jsonFilePath;
        public UserRepo(string jsonFilePath)
        {
            this.jsonFilePath = jsonFilePath;
            LoadFromJson();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepo"/> class.
        /// </summary>

        /// <summary>
        /// Adds a user to the repository.
        /// </summary>
        /// <param name="user">The user to add.</param>
        public void CreateAdmin(Admin admin)
        {
            _users.Add(admin);
            SaveToJson();
        }

        public void CreateEmployee (Employee employee)
        {
            _users.Add(employee);
            SaveToJson();
        }

        /// <summary>
        /// Deletes a user with the specified ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        public void DeleteUser(int id)
        {
            var userToDelete = _users.FirstOrDefault(u => u.UserID == id);
            if (userToDelete != null)
            {
                _users.Remove(userToDelete);
                SaveToJson();
            }
        }

        /// <summary>
        /// Gets all users in the repository.
        /// </summary>
        /// <returns>An enumerable collection of users.</returns>
        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        /// <summary>
        /// Gets a user by their ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The user with the specified ID, or null if not found.</returns>
        public User GetUserID(int id)
        {
            return _users.FirstOrDefault(u => u.UserID == id);
        }

        /// <summary>
        /// Gets a user by their type.
        /// </summary>
        /// <param name="type">The type of the user as a string.</param>
        /// <returns>The first user with the specified type, or null if not found.</returns>
        public User GetUserType(string type)
        {
            return _users.FirstOrDefault(u => u.Type.ToString() == type);
        }

        /// <summary>
        /// Prints the details of a user with the specified ID to the console.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        public void GetUserDetails(int id)
        {
            var user = _users.FirstOrDefault(u => u.UserID == id);
            if (user != null)
            {
                Console.WriteLine($"User Details: {user.Name}, {user.PhoneNumber}, {user.Email}");
            }
        }

        /// <summary>
        /// Updates the information of a user in the repository.
        /// </summary>
        /// <param name="user">The user with updated information.</param>
        public void UpdateUser(User user)
        {
            User userToUpdate = null;
            foreach (var u in _users)
            {
                if (u.UserID == user.UserID)
                {
                    userToUpdate = u;
                    break;
                }
            }
            if (userToUpdate != null)
            {
                userToUpdate.Name = user.Name;
                userToUpdate.PhoneNumber = user.PhoneNumber;
                userToUpdate.Email = user.Email;
                userToUpdate.Type = user.Type;
                SaveToJson();
            }
        }

        public void LoadFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                var json = File.ReadAllText(jsonFilePath);
                var options = new JsonSerializerOptions
                {
                    Converters = { new UserJsonConverter() },
                    PropertyNameCaseInsensitive = true
                };
                var loadedUsers = JsonSerializer.Deserialize<List<User>>(json, options);
                if (loadedUsers != null)
                {
                    _users = loadedUsers;
                }
            }
        }

        public void SaveToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new UserJsonConverter() }
            };
            var json = JsonSerializer.Serialize(_users, options);
            File.WriteAllText(jsonFilePath, json);
        }
    }
}



/// /Magnus Hansen
