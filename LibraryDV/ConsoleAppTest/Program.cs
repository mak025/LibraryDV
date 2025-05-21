using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
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
            ActivityRepo _actRepo = new ActivityRepo();
            ActivityService _actServ = new ActivityService(_actRepo);

            _actServ.CreateActivity("Test", "testtest", "nope", new DateOnly(2025, 12, 12), 12, 19);

            Activity act = _actServ.GetActivity(1);
            Console.WriteLine(act.ActivityTitle);

            _actServ.EditActivity(1, "Teeeeeeest", "testtest", "nope", new DateOnly(2025, 12, 12), 12, 19);
            Console.WriteLine(act.ActivityTitle);


            //BlogPost blogPost = new BlogPost("Test Title", "Test Content", "text");
            DateOnly newDate = new DateOnly(2025, 5, 19);

            var animalRepo = new AnimalRepo();
            var animalService = new AnimalService(animalRepo);

            animalService.CreateDog("Fiddo", "sort", "labrador", ["vaccine1", "vaccine2"], newDate, 32, "Dog_DESC", 'M', "path/to/image");

            //// Print all animal names in the _animalRepo list
            //// Print all animal names in the animals.json file using AnimalRepo
            foreach (var animal in animalRepo.GetAllAnimals())
            {
                Console.WriteLine(animal.Name);
            }
            //var repo = new UserRepo();
            var userRepo = new UserRepo();
            var userService = new UserServices(userRepo);

            //Employee employee = new Employee();
            userService.CreateEmployee("Egil", "22434889", "mail.mail@example.com", "lort");
            userService.CreateAdmin("AdminUsername", "12974320", "admin@example.com", "adminpass");
            userService.CreateAdmin("AdminUser2", "49865489", "admin2@example.com", "AdminPass12");

            List<Animal> animalList = animalService.GetAllAnimals();
            foreach (var animal in animalList)
                {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
