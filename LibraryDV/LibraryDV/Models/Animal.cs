using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryDV.Models
{
    /// Magnus Hansen
    /// <summary>
    /// Represents a base class for animals with common properties.
    /// </summary>
    public abstract class Animal
    {
        private static int _staticID = 1;
        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// enum AnimalType is only used in AnimalJsonConverter.cs for deserialization purposes.
        /// </summary>
        public enum AnimalType
        {
            /// <summary>
            /// Represents a dog.
            /// </summary>
            Dog, // Type Identifier for Dog = 0
            /// <summary>
            /// Represents a cat.
            /// </summary>
            Cat, // Type Identifier for Cat = 1
        }

        /// <summary>
        /// Gets or sets the unique identifier for the animal.
        /// </summary>
        public int AnimalID { get; set; }

        public AnimalType Type { get; set; }
        /// <summary>
        /// Gets or sets the color of the animal.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the race or breed of the animal.
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// Gets or sets the list of vaccines the animal has received.
        /// </summary>
        public string[] Vaccines { get; set; }

        /// <summary>
        /// Gets or sets the birthday of the animal.
        /// </summary>
        public DateOnly Birthday { get; set; }

        /// <summary>
        /// Gets or sets the weight of the animal.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the description of the animal.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the gender of the animal.
        /// </summary>
        public char Gender { get; set; }

        /// <summary>
        /// Gets or sets the image path for the animal.
        /// </summary>
        public string ImgPath { get; set; }

        /// <summary>
        /// Dictionary to hold health logs for the animal, with date as key and log description as value.
        /// </summary>
        public Dictionary<DateTime, string> HealthLogs { get; set; } = new();


        public Animal(string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
        {
            Name = name;
            Color = color;
            Race = race;
            Vaccines = vaccines;
            Birthday = birthday;
            Weight = weight;
            Description = description;
            Gender = gender;
            ImgPath = imgPath;
            AnimalID = _staticID++;
        }
    }

    

    /// <summary>
    /// Represents a dog, derived from Animal, with a chip number.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Gets or sets the chip number of the dog.
        /// </summary>
        public string ChipNumber { get; set; }
        public Dog(string chipNumber, string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath) 
            :base(name, color, race, vaccines, birthday, weight, description, gender, imgPath)
        {
            ChipNumber = chipNumber;
            Type = AnimalType.Dog; // Set the type to Dog
            // Default constructor
        }
    }

    /// <summary>
    /// Represents a cat, derived from Animal, with a chip number.
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Gets or sets the chip number of the cat.
        /// </summary>
        public string ChipNumber { get; set; }

        public Cat(string chipNumber, string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
            : base(name, color, race, vaccines, birthday, weight, description, gender, imgPath)
        {
            ChipNumber = chipNumber;
            Type = AnimalType.Cat; // Set the type to Cat
        }
    }

}
/// /Magnus Hansen
