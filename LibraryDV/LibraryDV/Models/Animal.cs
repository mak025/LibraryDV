using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public abstract class Animal
    {
        public required string Name { get; set; }
        public required DateOnly BirthDate { get; set; }
        public required string Vaccines { get; set; }
        public required string Color { get; set; }
        public required string Gender { get; set; }
        public string weight { get; set; }
        public required string description { get; set; }

    }

    public class Dog : Animal
    {
        public required string Race { get; set; }
        public string ShortDescription { get; set; }
        public required int weight { get; set; }

    }

    public class Cat : Animal
    {

    }

    public class Hamster : Animal
    {

    }
}
