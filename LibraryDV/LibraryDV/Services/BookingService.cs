using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;
using LibraryDV.Repos;

namespace LibraryDV.Services
{
    class BookingService
    {
        private IBookingRepo _bookingInterface;
        
        public BookingService(IBookingRepo bookRepo)
        {
            _bookingInterface = bookRepo ?? throw new ArgumentNullException(nameof(bookRepo));
        }

        public List<Booking> GetAllBookings()
        {
            return _bookingInterface.GetAllBookings();
        }

        public void CreateBooking(Booking book)
        {
            _bookingInterface.CreateBooking(book);
        }

        
    }
}
