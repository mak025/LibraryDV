using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    interface IAnimalRepo
    {
        //find a specific animal by ID
        Animal GetAnimal();

        //find all animals
        List<Animal> GetAllAnimals();

        //add a new animal object to the list
        void CreateAnimal(Animal animal);

        //find a specific animal by ID and remove it
        void DeleteAnimal(int animalID);

        //takes a specific animal object and returns it again after edits have been made
        Animal EditAnimal(Animal animal);
    }
}
