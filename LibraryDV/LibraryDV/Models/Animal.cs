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
        public required int ID { get; set; }
        public required string Color { get; set; }
        public required string Race { get; set; }
        public required string[] Vaccines { get; set; }
        public DateOnly Birthday { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }
        public char Gender { get; set; }
        public string ImgPath { get; set; }
        public List<string> HealthLogs { get; set; }

    }

    public class Dog : Animal
    {
        public required double ChipNumber { get; set; }
    }

    public class Cat : Animal
    {
        public required double ChipNumber { get; set; }
    }

}
