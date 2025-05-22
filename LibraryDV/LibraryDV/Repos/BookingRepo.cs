using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibraryDV.Models;
using System.Diagnostics;

namespace LibraryDV.Repos
{
    class BookingRepo
    {
        //Lucas Ingvardtsen
        private List<Booking> _bookings = new List<Booking>();
        private readonly string _jsonFilePath = @"C:/LibraryDV/LibraryDV/LibraryDV/Json/Bookiings.json";

        public BookingRepo() 
        {
            LoadFromJson();
        }

        public void LoadFromJson()
        {
            if(File.Exists(_jsonFilePath))
            {
                Debug.WriteLine("File Exists!");
                string json = File.ReadAllText(_jsonFilePath);
                JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var loadedBookings = JsonSerializer.Deserialize<List<Booking>>(json, options);
                if(loadedBookings != null)
                {
                    _bookings = loadedBookings;

                }
            }
        }

        //find a specific booking
        public Booking GetBooking(int id)
        {
            return _bookings.FirstOrDefault(b => b.BookingID == id);
        }

        //find all bookings
        public List<Booking> GetAllBookings()
        {
            return _bookings;
        }

        //add a booking to the list
        public void CreateBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        //delete an existing booking
        public void DeleteBooking(int bookingId)
        {
            var BookingToDelete = _bookings.FirstOrDefault(b => b.BookingID == bookingId);
            if (BookingToDelete != null)
            {
                _bookings.Remove(BookingToDelete);
            }
        }

        
    }
}
