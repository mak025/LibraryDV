using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    internal interface IBooking
    {
        void Add(Booking booking);

        public List<Booking> GetAll();

        void Delete(int bookingId);
    }
}
