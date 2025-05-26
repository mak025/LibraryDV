using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
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
