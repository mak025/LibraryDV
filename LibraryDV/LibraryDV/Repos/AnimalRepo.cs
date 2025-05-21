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
using System.Text.Json;
using System.IO;
using LibraryDV.Repos.Converters;

namespace LibraryDV.Repos
{
    public class AnimalRepo : IAnimalRepo
    {
        private List<Animal> _animals = new List<Animal>();
        private readonly string jsonFilePath;
        public AnimalRepo(string jsonFilePath)
        {
            this.jsonFilePath = jsonFilePath;
            LoadFromJson();
        }
        public void SaveToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new AnimalJsonConverter() }
            };
            var json = JsonSerializer.Serialize(_animals, options);
            File.WriteAllText(jsonFilePath, json);
        }

        public void LoadFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Converters = { new AnimalJsonConverter() }, // You need to implement this
                    PropertyNameCaseInsensitive = true
                };
                var loadedAnimals = JsonSerializer.Deserialize<List<Animal>>(json, options);
                if (loadedAnimals != null)
                {
                    _animals = loadedAnimals;
                }
            }
        }

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
        public void CreateDog(Dog animal)
        {
            _animals.Add(animal);
            SaveToJson();
        }
        public void CreateCat(Cat animal)
        {
            _animals.Add(animal);
            SaveToJson();
        }

        //find a specific animal by ID and remove it
        public void DeleteAnimal(int animalID)
        {
            var animalToDelete = _animals.FirstOrDefault(b => b.AnimalID == animalID);
            if (animalToDelete != null)
            {
                _animals.Remove(animalToDelete);
                SaveToJson();
            }
        }
        
        //takes all properties as input and updates the animal with the given ID
        public void EditAnimal(
            int oldID,
    string newName,
    string newColor,
    string newRace,
    string[] newVaccines,
    DateOnly newBirthday,
    double newWeight,
    string newDescription,
    char newGender,
    string newImgPath,
    List<string> newHealthLogs)
        {
            Animal old = GetAnimal(oldID);
            old.Name = newName;
            old.Color = newColor;
            old.Race = newRace;
            old.Vaccines = newVaccines;
            old.Birthday = newBirthday;
            old.Weight = newWeight;
            old.Description = newDescription;
            old.Gender = newGender;
            old.ImgPath = newImgPath;
            old.HealthLogs = newHealthLogs;
        }
        
            

        public List<Animal> FilterAnimals(
            string name,
            string race)
        {
            return _animals;
        }
    }
}
