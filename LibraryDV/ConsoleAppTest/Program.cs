using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
using LibraryDV.Repos;
using LibraryDV.Services;
using static LibraryDV.Models.User;

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

            animalService.CreateDog("Buller", "grøn", "labrador", new string[] { "venlig", "legende" }, new DateOnly(2020, 5, 19), 10.0, "han er sød", 'M', "imgpath");

            // Print all animal names in the _animalRepo list
            foreach (var animal in animalRepo.GetAllAnimals())
            {
                Console.WriteLine(animal.Name);
            }
            //var repo = new UserRepo();
            var userRepo = new UserRepo(@"C:\LibraryDV\LibraryDV\LibraryDV\Json\users.json");
            var userService = new UserServices(userRepo);

            //Employee employee = new Employee();
            userService.CreateEmployee("Egil", "22434889", "mail.mail@example.com", "lort");
            userService.CreateAdmin("AdminUsername", "12974320", "admin@example.com", "adminpass");
        }
    }
}
