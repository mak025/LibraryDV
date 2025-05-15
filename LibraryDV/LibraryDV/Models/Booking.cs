using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public class Booking
    {
        static int _tempID = 1;
        public int UserID { get; set; }
        public required int AnimalID { get; set; }
        public DateOnly Date { get; set; }
        public int Hour { get; set; }
        public int BookingID { get; set; }
        public string Comment { get; set; }






        public Booking(int userID, int animalID, DateOnly date, int hour, int bookingID, string comment)
        {
            UserID = userID;
            AnimalID = animalID;
            Date = date;
            Hour = hour;
            BookingID = _tempID;
            _tempID++;
            Comment = comment;
        }
    }
}
    

