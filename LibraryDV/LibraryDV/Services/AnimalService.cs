using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Repos;
using LibraryDV.Models;
using System.Diagnostics;

namespace LibraryDV.Services
{
   public class AnimalService
    {
        private IAnimalRepo _animalInterface;

        public AnimalService(IAnimalRepo IAnimal)
        {
            _animalInterface = IAnimal;
        }

        public void CreateDog(string chipNumber, string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
        {
            // Check for duplicates
            List<Animal> allAnimals = _animalInterface.GetAllAnimals().ToList();

            try {
                foreach (Dog animal in allAnimals)
                {

                    if (animal.ChipNumber == chipNumber &&
                        animal.Name == name &&
                        animal.Color == color &&
                        animal.Race == race &&
                        animal.Birthday == birthday &&
                        animal.Weight == weight &&
                        animal.Description == description &&
                        animal.Gender == gender &&
                        animal.ImgPath == imgPath) 
                    else
                        Debug.WriteLine("No identical animal found, creating new one");
                    _animalInterface.CreateDog(new Dog(chipNumber, name, color, race, vaccines, birthday, weight, description, gender, imgPath));

                }
            }
            }
        

        public void CreateCat(string chipNumber, string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
        {
            _animalInterface.CreateCat(new Cat(chipNumber, name, color, race, vaccines, birthday, weight, description, gender, imgPath));
        }

        public List<Animal> GetAllAnimals()
        { 
            return _animalInterface.GetAllAnimals();
        }

        public Animal GetAnimal(int id)
        {
            return _animalInterface.GetAnimal(id);
        }

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
            _animalInterface.EditAnimal(oldID, newName, newColor, newRace, newVaccines, newBirthday, newWeight, newDescription, newGender, newImgPath);
        }

        public void AddToHealthLog(int animalID, string toAdd)
        {
            _animalInterface.AddToHealthLog(animalID, toAdd);
        }

        public Dictionary<DateTime, string> GetHealthLog(int animalID)
        {
            return _animalInterface.GetHealthLog(animalID);
        }

        public List<Animal> FilterAnimalsByType(string type)
        {
            return _animalInterface.FilterAnimalsByType(type);
        }


        public List<Animal> SortAnimalsByWeight()
        {
            return _animalInterface.SortAnimalsByWeight();
        }
    }
}
