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
        public required int ID { get; set; }

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
    }

}
/// /Magnus Hansen
