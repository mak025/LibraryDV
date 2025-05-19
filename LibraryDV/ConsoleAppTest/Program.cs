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

            var animalRepo = new AnimalRepo();
            var animalService = new AnimalService(animalRepo);

            animalService.CreateAnimal(animal1);

            // Print all animal names in the _animalRepo list
            foreach (var animal in animalRepo.GetAllAnimals())
            {
                Console.WriteLine(animal.Name);
            }

            Animal animal2 = animalService.GetAnimal(1);
            Console.WriteLine(animal2.Name);
        }
    }
}
