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

            ActivityRepo activityRepo = new ActivityRepo();
            ActivityService activityService = new ActivityService(activityRepo);
            var animalRepo = new AnimalRepo();
            var animalService = new AnimalService(animalRepo);

            activityService.CreateActivity("Test titel", "Test text", "nope", DateOnly.FromDateTime(DateTime.Now), 10, 14);
            activityService.CreateActivity("Test tite1231l", "Test 12311231text", "nop1212e", DateOnly.FromDateTime(DateTime.Now), 14, 15);
            animalService.CreateAnimal(animal1);

            // Print all animal names in the _animalRepo list
            foreach (var animal in animalRepo.GetAllAnimals())
            {
                Console.WriteLine(animal.Name);
            }

            foreach (Activity activity in activityService.GetAllActivities())
            {
                Console.WriteLine(activity.ActID);
            }    
            Animal animal2 = animalService.GetAnimal(1);
            Console.WriteLine(animal2.Name);
        }
    }
}
