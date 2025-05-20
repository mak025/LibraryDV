using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
using LibraryDV.Repos;
using LibraryDV.Services;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogPost = new BlogPost("Test Title", "Test Content", "text");
            //DateOnly newDate = new DateOnly(2025, 5, 19);
            Animal animal1 = new Dog("Buller", "grøn", "labrador", new string[] { "venlig", "legende" }, new DateOnly(2020, 5, 19), 10.0, "han er sød", 'M', "imgpath");
            Animal animal2 = new Dog("Buller", "grøn", "labrador", new string[] { "venlig", "legende" }, new DateOnly(2020, 5, 19), 130.0, "han er sød", 'M', "imgpath");
            Animal animal3 = new Dog("Buller", "grøn", "labrador", new string[] { "venlig", "legende" }, new DateOnly(2020, 5, 19), 50.0, "han er sød", 'M', "imgpath");
            Animal animal4 = new Dog("Buller", "grøn", "labrador", new string[] { "venlig", "legende" }, new DateOnly(2020, 5, 19), 5.0, "han er sød", 'M', "imgpath");

            var animalRepo = new AnimalRepo();
            var animalService = new AnimalService(animalRepo);

            animalService.CreateAnimal(animal1);
            animalService.CreateAnimal(animal2);
            animalService.CreateAnimal(animal3);
            animalService.CreateAnimal(animal4);

            // Print all animal names in the _animalRepo list
            foreach (var animal in animalRepo.GetAllAnimals())
            {
                Console.WriteLine(animal.Name);
            }

            Console.WriteLine("SortTest:");
            foreach (var animal in animalRepo.SortAnimalsByWeight())
            {
                Console.WriteLine(animal.Weight);
            }

            Animal animal5 = animalService.GetAnimal(1);
            Console.WriteLine(animal2.Name);
        }
    }
}
