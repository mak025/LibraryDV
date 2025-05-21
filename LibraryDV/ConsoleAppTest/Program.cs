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
            AnimalRepo _animalRepo = new AnimalRepo(@"C:\LibraryDV\LibraryDV\LibraryDV\Json\animals.json");
            AnimalService _animalServ = new AnimalService(_animalRepo);
            List<Animal> _animals = _animalServ.GetAllAnimals();
            int i = 1;

            foreach(Animal animal in _animals)
            {
                string toAdd = $"testestestest12 {i}";
                _animalServ.AddToHealthLog(animal.AnimalID, toAdd);
                i++;
                //Dictionary<DateTime, string> hLog = new Dictionary<DateTime, string>();  
                Console.WriteLine(_animalServ.GetHealthLog(animal.AnimalID));
            }
            //var repo = new UserRepo();
            var userRepo = new UserRepo(@"C:\LibraryDV\LibraryDV\LibraryDV\Json\users.json");
            var userService = new UserServices(userRepo);

            //Employee employee = new Employee();
            userService.CreateEmployee("Egil", "22434889", "mail.mail@example.com", "lort");
            userService.CreateAdmin("AdminUsername", "12974320", "admin@example.com", "adminpass");
            userService.CreateAdmin("AdminUser2", "49865489", "admin2@example.com", "AdminPass12");
        }
    }
}
