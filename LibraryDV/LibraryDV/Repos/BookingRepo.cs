using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    class BookingRepo
    {
        //Lucas Ingvardtsen
        private List<Booking> _bookings = new List<Booking>();

        public BookingRepo() { }

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

        public void AddBooking(Booking booking)
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
