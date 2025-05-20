using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LibraryDV.Models;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace LibraryDV.Repos
{
    public class AnimalRepo : IAnimalRepo
    {
        private List<Animal> _animals = new List<Animal>();

        //default constructor
        public AnimalRepo() { }

        //find a specific animal by ID
        public Animal GetAnimal(int id)
        {
            foreach (Animal animal in _animals)
            {
                if (id == animal.AnimalID)
                {
                    return animal;
                }
            }
            return null;
        }

        //find all animals
        public List<Animal> GetAllAnimals()
        {
            return _animals;
        }

        //add a new animal object to the list
        public void CreateAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        //find a specific animal by ID and remove it
        public void DeleteAnimal(int animalID)
        {
            var animalToDelete = _animals.FirstOrDefault(b => b.AnimalID == animalID);
            if (animalToDelete != null)
            {
                _animals.Remove(animalToDelete);
            }
        }

        //takes all properties as input and updates the animal with the given ID
        public Animal EditAnimal(
            int id,
    string name,
    string color,
    string race,
    string[] vaccines,
    DateOnly birthday,
    double weight,
    string description,
    char gender,
    string imgPath,
    List<string> healthLogs)
        {
            var animal = _animals.FirstOrDefault(a => a.AnimalID == id);
            // Check if the animal with the given ID exists if it does not, throw an exception, else update the animal
            if (animal == null)
            {
                throw new InvalidOperationException($"Animal with ID {id} not found.");
            }
            
            animal.Name = name;
            animal.Color = color;
            animal.Race = race;
            animal.Vaccines = vaccines;
            animal.Birthday = birthday;
            animal.Weight = weight;
            animal.Description = description;
            animal.Gender = gender;
            animal.ImgPath = imgPath;
            animal.HealthLogs = healthLogs;

            return animal;
        }

        public List<Animal> FilterAnimals(
            string name,
            string race)
        {
            return _animals;
        }

        public List<Animal> SortAnimalsByName()
        {
            List<Animal> animalsToSort = GetAllAnimals();


        }
    }
}
