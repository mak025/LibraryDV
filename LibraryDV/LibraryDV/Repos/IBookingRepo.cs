using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    public interface IBookingRepo
    {
        //create a new booking object and add it to the list of bookings
        public void CreateBooking(Booking booking);

        public void DeleteBooking(int bookingID);

        //find a specific booking
        public Booking GetBooking(int id);

        public List<Booking> GetAllBookings();

    }
}
