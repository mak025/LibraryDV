using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
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
            : base(name, color, race, vaccines, birthday, weight, description, gender, imgPath)
        {
            ChipNumber = chipNumber;
            Type = AnimalType.Dog; // Set the type to Dog
            // Default constructor
        }
    }
}
