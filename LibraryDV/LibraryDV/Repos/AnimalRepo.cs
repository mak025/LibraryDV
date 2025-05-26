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

    //Egil, Marcus, Magnus & Lucas
    /// <summary>
    /// Repository for managing animal data, including dogs and cats.
    /// </summary>
    public class AnimalRepo : IAnimalRepo
    {

        /// <summary>
        /// List of all animals managed by the repository.
        /// </summary>
        private List<Animal> _animals = new List<Animal>();
        /// <summary>
        /// The file path to the JSON file used for persisting animal data.
        /// </summary>
        private readonly string _jsonFilePath = @"C:\LibraryDV\LibraryDV\LibraryDV\Json\pets.json";

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimalRepo"/> class and loads animal data from the JSON file.
        /// </summary>
        public AnimalRepo()
        {
            LoadFromJson();
        }

        /// <summary>
        /// Saves the current list of animals to the JSON file.
        /// Exception Handler tries to serialize the list of animals to JSON and write it to the file, if an error occurs, the catch will type a message in the debug window.
        /// </summary>
        public void SaveToJson()
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters = { new AnimalJsonConverter() }
                };
                var json = JsonSerializer.Serialize(_animals, options);
                File.WriteAllText(_jsonFilePath, json);
            }
            catch
            {
                Debug.WriteLine("Error saving to JSON file. Please check the file path and permissions.");
            }
        }

        /// <summary>
        /// Loads the list of animals from the JSON file, if it exists.
        /// </summary>
        public void LoadFromJson()
        {
            if (File.Exists(_jsonFilePath))
            {
                string json = File.ReadAllText(_jsonFilePath);
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Converters = { new AnimalJsonConverter() },
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
    string newImgPath)
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
            SaveToJson();
        }
        
        /// Adds a new health log entry for the specified animal.
        /// </summary>
        /// <param name="animalID">The unique identifier of the animal.</param>
        /// <param name="toAdd">The health log description to add.</param>
        public void AddToHealthLog(int animalID, string toAdd)
        {
            Animal animal = GetAnimal(animalID);
            animal.HealthLogs.Add(DateTime.Now, toAdd);
            SaveToJson();
        }
        /// <summary>
        /// Removes a health log entry using the dictionary key (log date) for a specific animal by its ID.
        /// </summary>
        /// <param name="animalID">The unique identifier of the animal.</param>
        /// <param name="logDate">The date of the health log entry to remove.</param>
        public void RemoveHealthLogEntry(int animalID, DateTime logDate)
        {
            Animal animal = GetAnimal(animalID);
            if (animal != null && animal.HealthLogs.ContainsKey(logDate))
            {
                animal.HealthLogs.Remove(logDate);
                SaveToJson();
            }
        }

        /// <summary>
        /// Edits an existing health log entry for a specific animal by its ID and healthlog dictionary key log date.
        /// </summary>
        /// <param name="animalID">The constructor id for the animal</param>
        /// <param name="logDate">the date of the log</param>
        /// <param name="newDescription">log description</param>
        public void EditHealthLogEntry(int animalID, DateTime logDate, string newDescription)
        {
            Animal animal = GetAnimal(animalID);
            if (animal != null && animal.HealthLogs.ContainsKey(logDate))
            {
                animal.HealthLogs[logDate] = newDescription;
                SaveToJson();
            }
        }

        /// <summary>
        /// Retrieves the health log for a specific animal by its ID.
        /// </summary>
        /// <param name="animalID">the id of the animal</param>
        /// <returns></returns>
        public Dictionary<DateTime, string> GetHealthLog(int animalID)
        {
            Animal animal = GetAnimal(animalID);
            return animal.HealthLogs;
        }

        /// <summary>
        /// Filters out animals that are not of the given type (Dog or Cat).
        /// </summary>
        /// <param name="type">the string which determines what type to filter for</param>
        /// <returns>A list which only contains animals with a type matching the input</returns>
        public List<Animal> FilterAnimalsByType(string type)
        {
            List<Animal> _filteredAnimals = new List<Animal>();

            foreach (Animal animal in _animals)
            {
                if(type.Equals(animal.Type.ToString()))
                {
                    _filteredAnimals.Add(animal);
                }
            }

            return _filteredAnimals;
        }

        /// <summary>
        /// Sorts all animals by their weight using insertion sort algorithm.
        /// </summary>
        /// <returns>A list of animals sorted from lightest to heaviest</returns>
        public List<Animal> SortAnimalsByWeight()
        {
            List<Animal> animalsToSort = GetAllAnimals();

            for (int i = 1;  i < animalsToSort.Count; i++)
            {
                double currentWeight = animalsToSort[i].Weight;
                int j = i - 1;

                while (j >= 0 && animalsToSort[j].Weight > currentWeight)
                {
                    (animalsToSort[j], animalsToSort[j + 1]) = (animalsToSort[j + 1], animalsToSort[j]);
                    j--;
                }
            }

            return animalsToSort;
        }
    }
}
