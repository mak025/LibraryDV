using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using LibraryDV.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryDV.Models.User;
using System.Diagnostics;

namespace LibraryDV.Repos.Converters
{
    // This class helps convert User objects to and from JSON format
    public class UserJsonConverter : JsonConverter<User>
    {
        // This method reads JSON and creates the correct User object (Customer, Employee, or Admin)
        public override User Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Parse the JSON data into a JsonDocument for easier access
            using (JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                JsonElement root = jsonDoc.RootElement; // Get the root element of the JSON

                // Check if the JSON contains the "Type" property (used to know which User type to create)
                if (!root.TryGetProperty("Type", out JsonElement typeProperty))
                {
                    throw new JsonException("Missing Type Indicator"); // Throw error if "Type" is missing
                }

                int typeIndicator = typeProperty.GetInt32(); // Get the value of the "Type" property as a string
                User user = null; // This will hold the created User object

                // Check the type and deserialize into the correct class
                if (typeIndicator == 0) // Customer
                {
                    // If type is Customer, create a Customer object from JSON
                    user = JsonSerializer.Deserialize<Customer>(root.GetRawText(), options);
                }
                else if (typeIndicator == 1) // Employee
                {
                    // If type is Employee, create an Employee object from JSON
                    user = JsonSerializer.Deserialize<Employee>(root.GetRawText(), options);
                }
                else if (typeIndicator == 2) // Admin

                {
                    // If type is Admin, create an Admin object from JSON
                    user = JsonSerializer.Deserialize<Admin>(root.GetRawText(), options);
                }
                else
                {
                    // If type is unknown, throw an error
                    throw new JsonException($"Unknown user type: {typeIndicator}");
                }

                return user; // Return the created User object
            }
        }

        // This method writes a User object to JSON
        public override void Write(Utf8JsonWriter writer, User value, JsonSerializerOptions options)
        {
            // Check the actual type of the User object and serialize accordingly
            if (value is Customer)
            {
                // If it's a Customer, write it as a Customer
                JsonSerializer.Serialize(writer, (Customer)value, options);
            }
            else if (value is Admin)
            {
                // If it's an Admin, write it as an Admin
                JsonSerializer.Serialize(writer, (Admin)value, options);
            }
            else if (value is Employee)
            {
                // If it's an Employee, write it as an Employee
                JsonSerializer.Serialize(writer, (Employee)value, options);
            }
            else
            {
                // If the type is unknown, throw an error
                throw new JsonException($"Unknown user type: {value.GetType().Name}");
            }
        }
    }

}
