using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    public interface IAnimalRepo
    {
        //find a specific animal by ID
        Animal GetAnimal(int id);

        //find all animals
        List<Animal> GetAllAnimals();

        //add a new animal object to the list
        void CreateAnimal(Animal animal);

        //find a specific animal by ID and remove it
        void DeleteAnimal(int animalID);

        //takes a specific animal object and returns it again after edits have been made
        Animal EditAnimal(
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
    List<string> healthLogs);

        //takes 2 inputs that describe the animal and returns a list of animals that match the inputs
        List<Animal> FilterAnimals(
            string name,
            string race
        );
    }
}
