using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos

/// Magnus Hansen
{
    /// <summary>
    /// Repository for managing users in the library system.
    /// </summary>
    class UserRepo : IUserRepo
    {
        /// <summary>
        /// List to store users.
        /// </summary>
        private List<User> users = new List<User>();
        private readonly string jsonFilePath = Path.Combine("Json", "users.json");

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepo"/> class.
        /// </summary>
        public UserRepo()
        {
            LoadFromJson();
        }

        /// <summary>
        /// Adds a user to the repository.
        /// </summary>
        /// <param name="user">The user to add.</param>
        public void AddUser(User user)
        {
            users.Add(user);
            SaveToJson();
        }

        /// <summary>
        /// Deletes a user with the specified ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        public void DeleteUser(int id)
        {
            var userToDelete = users.FirstOrDefault(u => u.UserID == id);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
                SaveToJson();
            }
        }

        /// <summary>
        /// Gets all users in the repository.
        /// </summary>
        /// <returns>An enumerable collection of users.</returns>
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        /// <summary>
        /// Gets a user by their ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The user with the specified ID, or null if not found.</returns>
        public User GetUserID(int id)
        {
            return users.FirstOrDefault(u => u.UserID == id);
        }

        /// <summary>
        /// Gets a user by their type.
        /// </summary>
        /// <param name="type">The type of the user as a string.</param>
        /// <returns>The first user with the specified type, or null if not found.</returns>
        public User GetUserType(string type)
        {
            return users.FirstOrDefault(u => u.Type.ToString() == type);
        }

        /// <summary>
        /// Prints the details of a user with the specified ID to the console.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        public void GetUserDetails(int id)
        {
            var user = users.FirstOrDefault(u => u.UserID == id);
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
            foreach (var u in users)
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
                    users = loadedUsers;
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
            var json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(jsonFilePath, json);
        }
    }
}



/// /Magnus Hansen
