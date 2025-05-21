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
            AnimalRepo _animalRepo = new AnimalRepo();
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
        }
    }
}
