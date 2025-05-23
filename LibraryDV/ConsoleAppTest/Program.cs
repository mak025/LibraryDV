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
using System.Diagnostics;

namespace ConsoleAppTest
{

    internal class Program
    {
        static void Main(string[] args)
        {

            IBlogPostRepo BlogPostRepo = new BlogPostRepo();
            BlogPostService blogPostService = new BlogPostService(BlogPostRepo);

            blogPostService.CreateBlogPost("Test Title 1", "ImgPath", "Test Content");
            Console.WriteLine("Test Blogpost Created #1");
            blogPostService.CreateBlogPost("Test Title 2", "ImgPath", "Test Content");
            Console.WriteLine("Test Blogpost Created #2");


            //// Ensure there is at least one animal to test with
            //Animal animal = repo.GetAnimal(1);
            //if (animal == null)
            //{
            //    Dog newDog = new Dog(
            //        name: "TestDog",
            //        color: "Brown",
            //        race: "Labrador",
            //        vaccines: new string[] { "Rabies" },
            //        birthday: new DateOnly(2020, 1, 1),
            //        weight: 20.0,
            //        description: "Healthy dog",
            //        gender: 'M',
            //        imgPath: "imgpath"
            //    );
            //    repo.CreateDog(newDog);
            //    animal = repo.GetAnimal(newDog.AnimalID);
            //}

            //int animalID = animal.AnimalID;

            //// Add a health log entry
            //repo.AddToHealthLog(animalID, "Initial checkup - pre edit");
            //Console.WriteLine("Added health log entry.");

            //// Get and display health logs
            //var logs = repo.GetHealthLog(animalID);
            //foreach (var log in logs)
            //{
            //    Console.WriteLine($"{log.Key}: {log.Value}");
            //}

            //// Edit the first health log entry
            //if (logs.Count > 0)
            //{
            //    var firstLog = new KeyValuePair<DateTime, string>();
            //    foreach (var log in logs)
            //    {
            //        firstLog = log;
            //        break;
            //    }
            //    repo.EditHealthLogEntry(animalID, firstLog.Key, "Updated checkup");
            //    Console.WriteLine("Edited health log entry.");
            //}

            ////// Remove the first health log entry
            ////if (logs.Count > 0)
            ////{
            ////    var firstLog = new KeyValuePair<DateTime, string>();
            ////    foreach (var log in logs)
            ////    {
            ////        firstLog = log;
            ////        break;
            ////    }
            ////    repo.RemoveHealthLogEntry(animalID, firstLog.Key);
            ////    Console.WriteLine("Removed health log entry.");
            ////}

            //// Display health logs after removal
            //logs = repo.GetHealthLog(animalID);
            //Console.WriteLine("Health logs after removal:");
            //foreach (var log in logs)
            //{
            //    Console.WriteLine($"{log.Key}: {log.Value}");
            //}


        }

        public static void Test()
        {
            IBookingRepo bi = new BookingRepo();
            BookingService _bs = new BookingService(bi);
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);

            _bs.CreateBooking(1, 2, date, 14, "Buller 2.0 ftw");
            _bs.CreateBooking(4, 2, date, 15, "Buller 2.0 ftw");
            _bs.CreateBooking(3, 2, date, 10, "Buller 2.0 ftw");

            Console.WriteLine("woo pwoop");
            Console.ReadKey();
        }
    }
}
