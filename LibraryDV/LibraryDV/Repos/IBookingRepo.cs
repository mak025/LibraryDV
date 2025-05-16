using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    interface IBookingRepo
    {   
        //find all booking
        public List<Booking> GetAllBookings();

        //find a specific booking
        public Booking GetBooking();

        //create a new booking object and add it to the list of bookings
        public Booking CreateBooking(Booking booking);

        
    }
}
