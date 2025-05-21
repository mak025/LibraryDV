using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Repos;
using LibraryDV.Models;

namespace LibraryDV.Services
{
   public class AnimalService
    {
        private IAnimalRepo _animalInterface;

        public AnimalService(IAnimalRepo IAnimal)
        {
            _animalInterface = IAnimal;
        }

        public void CreateDog(string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
        {
            _animalInterface.CreateDog(new Dog(name, color, race, vaccines, birthday, weight, description, gender, imgPath));
        }

        public void CreateCat(string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
        {
            _animalInterface.CreateCat(new Cat(name, color, race, vaccines, birthday, weight, description, gender, imgPath));
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
    string newImgPath,
    List<string> newHealthLogs)
        {
            _animalInterface.EditAnimal(oldID, newName, newColor, newRace, newVaccines, newBirthday, newWeight, newDescription, newGender, newImgPath, newHealthLogs);

        }

        public List<Animal> FilterAnimalsByType(string type)
        {
            return _animalInterface.FilterAnimalsByType(type);
        }

        public List<Animal> SortAnimalByWeigth()
        {
            return _animalRepo.SortAnimalsByWeight();
        }
    }
}
