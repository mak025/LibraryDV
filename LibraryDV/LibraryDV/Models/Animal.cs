using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    /// Magnus Hansen
    /// <summary>
    /// Represents a base class for animals with common properties.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the animal.
        /// </summary>
        public required int AnimalID { get; set; }

        /// <summary>
        /// Gets or sets the color of the animal.
        /// </summary>
        public required string Color { get; set; }

        /// <summary>
        /// Gets or sets the race or breed of the animal.
        /// </summary>
        public required string Race { get; set; }

        /// <summary>
        /// Gets or sets the list of vaccines the animal has received.
        /// </summary>
        public required string[] Vaccines { get; set; }

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
        /// Gets or sets the health logs for the animal.
        /// </summary>
        public List<string> HealthLogs { get; set; }
    }

    /// <summary>
    /// Represents a dog, derived from Animal, with a chip number.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Gets or sets the chip number of the dog.
        /// </summary>
        public required double ChipNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class with parameters.
        /// </summary>
        /// <param name="name">The name of the dog.</param>
        /// <param name="animalID">The unique identifier for the dog.</param>
        /// <param name="color">The color of the dog.</param>
        /// <param name="race">The race or breed of the dog.</param>
        /// <param name="vaccines">The list of vaccines the dog has received.</param>
        /// <param name="birthday">The birthday of the dog.</param>
        /// <param name="weight">The weight of the dog.</param>
        /// <param name="description">The description of the dog.</param>
        /// <param name="gender">The gender of the dog.</param>
        /// <param name="imgPath">The image path for the dog.</param>
        /// <param name="healthLogs">The health logs for the dog.</param>
        /// <param name="chipNumber">The chip number of the dog.</param>
        public Dog( string name, int animalID, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath, List<string> healthLogs, double chipNumber)
        {
            Name = name;
            AnimalID = animalID;
            Color = color;
            Race = race;
            Vaccines = vaccines;
            Birthday = birthday;
            Weight = weight;
            Description = description;
            Gender = gender;
            ImgPath = imgPath;
            HealthLogs = healthLogs;
            ChipNumber = chipNumber;
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
        public required double ChipNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class with parameters.
        /// </summary>
        /// <param name="name">The name of the cat.</param>
        /// <param name="animalID">The unique identifier for the cat.</param>
        /// <param name="color">The color of the cat.</param>
        /// <param name="race">The race or breed of the cat.</param>
        /// <param name="vaccines">The list of vaccines the cat has received.</param>
        /// <param name="birthday">The birthday of the cat.</param>
        /// <param name="weight">The weight of the cat.</param>
        /// <param name="description">The description of the cat.</param>
        /// <param name="gender">The gender of the cat.</param>
        /// <param name="imgPath">The image path for the cat.</param>
        /// <param name="healthLogs">The health logs for the cat.</param>
        /// <param name="chipNumber">The chip number of the cat.</param>
        public Cat(
            string name,
            int animalID,
            string color,
            string race,
            string[] vaccines,
            DateOnly birthday,
            double weight,
            string description,
            char gender,
            string imgPath,
            List<string> healthLogs,
            double chipNumber)
        {
            Name = name;
            AnimalID = animalID;
            Color = color;
            Race = race;
            Vaccines = vaccines;
            Birthday = birthday;
            Weight = weight;
            Description = description;
            Gender = gender;
            ImgPath = imgPath;
            HealthLogs = healthLogs;
            ChipNumber = chipNumber;
        }
    }

}
/// /Magnus Hansen
