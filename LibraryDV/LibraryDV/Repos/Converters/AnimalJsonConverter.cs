using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using LibraryDV.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryDV.Models.Animal;

namespace LibraryDV.Repos.Converters
{
    internal class AnimalJsonConverter : JsonConverter<Animal>
    {
        // This method reads pets.JSON and creates the correct Animal object (Dog, Cat)
        public override Animal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Parse the JSON data into a JsonDocument for easier access
            using (JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                JsonElement root = jsonDoc.RootElement; // Get the root element of the JSON

                // Check if the JSON contains the "Type" property (used to know which Animal type to create)
                if (!root.TryGetProperty("Type", out JsonElement typeProperty))
                {
                    throw new JsonException("Missing Type Indicator"); // Throw error if "Type" is missing
                }

                int typeIndicator = typeProperty.GetInt32(); // Get the value of the "Type" property as a string
                Animal animal = null; // This will hold the created Animal object

                // Check the type and deserialize into the correct class
                if (typeIndicator == 0) // Dog
                {
                    // If type is Dog, create a Dog object from JSON
                    animal = JsonSerializer.Deserialize<Dog>(root.GetRawText(), options);
                }
                else if (typeIndicator == 1) // Cat

                {
                    // If type is Cat, create an Cat object from JSON
                    animal = JsonSerializer.Deserialize<Cat>(root.GetRawText(), options);
                }
                else
                {
                    // If type is unknown, throw an error
                    throw new JsonException($"Unknown animal type: {typeIndicator}");
                }

                return animal; // Return the created Animal object
            }
        }

        // This method writes a Animal object to JSON
        public override void Write(Utf8JsonWriter writer, Animal value, JsonSerializerOptions options)
        {
            // Check the actual type of the Animal object and serialize accordingly
            if (value is Dog)
            {
                // If it's a Dog, write it as a Customer
                JsonSerializer.Serialize(writer, (Dog)value, options);
            }
            else if (value is Cat)
            {
                // If it's an Cat, write it as an Employee
                JsonSerializer.Serialize(writer, (Cat)value, options);
            }
            else
            {
                // If the type is unknown, throw an error
                throw new JsonException($"Unknown animal type: {value.GetType().Name}");
            }
        }
    }
}
