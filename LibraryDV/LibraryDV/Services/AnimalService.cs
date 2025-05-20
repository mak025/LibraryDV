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
        private IAnimalRepo _animalRepo;

        public AnimalService(IAnimalRepo animalRepo)
        {
            _animalRepo = animalRepo;
        }

        public void CreateDog(string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
        {
            _animalRepo.CreateDog(new Dog(name, color, race, vaccines, birthday, weight, description, gender, imgPath));
        }

        public void CreateCat(string name, string color, string race, string[] vaccines, DateOnly birthday, double weight, string description, char gender, string imgPath)
        {
            _animalRepo.CreateCat(new Cat(name, color, race, vaccines, birthday, weight, description, gender, imgPath));
        }

        public List<Animal> GetAllAnimals()
        { 
            return _animalRepo.GetAllAnimals();
        }

        public Animal GetAnimal(int id)
        {
            return _animalRepo.GetAnimal(id);
        }

        //Null is a placeholder return value
        public Animal EditAnimal()
        {
            return null;
        }

    }
}
