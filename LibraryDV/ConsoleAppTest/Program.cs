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
            // Repo Instances
            IActivityRepo activityRepo = new ActivityRepo();
            IAnimalRepo animalRepo = new AnimalRepo();
            IBlogPostRepo blogPostRepo = new BlogPostRepo();
            IBookingRepo bookingRepo = new BookingRepo();
            IUserRepo userRepo = new UserRepo();


            // Service Instances
            ActivityService activityService = new ActivityService(activityRepo);
            AnimalService animalService = new AnimalService(animalRepo);
            BlogPostService blogPostService = new BlogPostService(blogPostRepo);
            BookingService bookingService = new BookingService(bookingRepo);
            UserServices userService = new UserServices(userRepo);



            // Classes showcase - shows how to create objects from classes

            // Creating object from all services to test if they are working correctly by calling the // Create methods of each service.
            // Create a new activity
            activityService.CreateActivity(DateOnly.FromDateTime(DateTime.Now), "Test Activity", "This is a test activity.", "test.jpg", 9, 17);
            // Create a new dog
            // Create a new blog post
            blogPostService.CreateBlogPost("BlogPost Title", "", "Content of the blog post");
            // Create a new booking
            bookingService.CreateBooking(12, 1, DateOnly.Parse("12-06-2025"), 12, "no comment");
            // Create a new admin user
            userService.CreateAdmin("adminName", "29381672", "email@example.com", "ExamplePass12!");
            userService.CreateCustomer("Adam", "79823429", "adam@example.customer.com");




            // Inheritance showcase. prints the information of all users in the repository.
            foreach (User user in userRepo.GetAllUsers())
            {
                Console.WriteLine($"User ID: {user.UserID}, Name: {user.Name}, Type: {user.Type}");
            }






            // Exception handling showcase. Tries to read string from a file which does not exist, which will throw an exception.
            try
            {
                string content = System.IO.File.ReadAllText("nonexistentfile.json");
                Console.WriteLine(content);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            // Uncomment the following lines to see the exception handling in action
            //Create the file
            //finally
            //{
            //    // Create the file if it does not exist
            //    string filePath = "nonexistentfile.txt";
            //    if (!System.IO.File.Exists(filePath))
            //    {
            //        System.IO.File.WriteAllText(filePath, "This file was created because it did not exist.");
            //        Console.WriteLine($"File '{filePath}' has been created.");
            //    }
            //}
        }
    }
}
