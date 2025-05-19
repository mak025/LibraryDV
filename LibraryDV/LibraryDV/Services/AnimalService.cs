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

        public void CreateAnimal(Animal animal)
        {
            _animalRepo.CreateAnimal(animal);
        }

        public List<Animal> GetAllAnimals()
        { 
            return _animalRepo.GetAllAnimals();
        }

        //Null is a placeholder return value
        public Animal EditAnimal()
        {
            return null;
        }

    }
}
