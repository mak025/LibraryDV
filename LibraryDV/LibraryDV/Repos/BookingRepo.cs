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
    public class BookingRepo : IBookingRepo 
    {
        //Lucas Ingvardtsen
        private List<Booking> _bookings = new List<Booking>();
        private readonly string _jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON", "Bookings.json");

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

        public void SaveToJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(_bookings, options);
            File.WriteAllText(_jsonFilePath, json);
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
            SaveToJson();
        }

        //delete an existing booking
        public void DeleteBooking(int bookingId)
        {
            var BookingToDelete = _bookings.FirstOrDefault(b => b.BookingID == bookingId);
            if (BookingToDelete != null)
            {
                _bookings.Remove(BookingToDelete);
            }
            SaveToJson();
        }

        
    }
}
