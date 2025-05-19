using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using LibraryDV.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Repos
{
    public class UserJsonConverter : JsonConverter<User>
    {
        public override User Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                var root = jsonDoc.RootElement;

                if (!root.TryGetProperty("Type", out var typeProperty))
                {
                    throw new JsonException("Missing Type discriminator");
                }

                var typeString = typeProperty.GetString();
                User user = null;

                if (typeString == User.UserType.Customer.ToString())
                {
                    user = JsonSerializer.Deserialize<Customer>(root.GetRawText(), options);
                }
                else if (typeString == User.UserType.Employee.ToString())
                {
                    user = JsonSerializer.Deserialize<Employee>(root.GetRawText(), options);
                }
                else if (typeString == User.UserType.Admin.ToString())
                {
                    user = JsonSerializer.Deserialize<Admin>(root.GetRawText(), options);
                }
                else
                {
                    throw new JsonException($"Unknown user type: {typeString}");
                }

                return user;
            }
        }

        public override void Write(Utf8JsonWriter writer, User value, JsonSerializerOptions options)
        {
            if (value is Customer)
            {
                JsonSerializer.Serialize(writer, (Customer)value, options);
            }
            else if (value is Admin)
            {
                JsonSerializer.Serialize(writer, (Admin)value, options);
            }
            else if (value is Employee)
            {
                JsonSerializer.Serialize(writer, (Employee)value, options);
            }
            else
            {
                throw new JsonException($"Unknown user type: {value.GetType().Name}");
            }
        }
    }

}
