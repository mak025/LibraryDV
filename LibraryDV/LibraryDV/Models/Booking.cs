using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public class Booking
    {
        public int UserID { get; set; }
        public int AnimalID { get; set; }
        public DateOnly Date { get; set; }
        public int Hour { get; set; }
        public int BookingID { get; set; }
        public string Comment { get; set; }


    }
}
