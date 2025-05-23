using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
using LibraryDV.Repos;

namespace LibraryDV.Services
{
    public class BookingService
    {
        private IBookingRepo _bookingInterface;
        
        public BookingService(IBookingRepo bookRepo)
        {
            _bookingInterface = bookRepo ?? throw new ArgumentNullException(nameof(bookRepo));
        }
        public void CreateBooking(int userID, int animalID, DateOnly date, int hour, string comment)
        {
            _bookingInterface.CreateBooking(new Booking(userID, animalID, date, hour, comment));
        }

        public void DeleteBooking(int bookingID)
        {
            _bookingInterface.DeleteBooking(bookingID);
        }

        public Booking GetBooking(int id)
        {
            return _bookingInterface.GetBooking(id);
        }

        public List<Booking> GetAllBookings()
        {
            return _bookingInterface.GetAllBookings();
        }



        
    }
}
