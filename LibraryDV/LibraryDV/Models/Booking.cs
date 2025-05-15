using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public class Booking
    {
        ///Forfatter: Lucas Ingvardtsen
        /// <summary>
        /// TempID - 
        /// </summary>
        static int _tempID = 1;
        /// <summary>
        /// The users individual ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// The animals individual ID
        /// </summary>
        public required int AnimalID { get; set; }
        /// <summary>
        /// Date of booking
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// Hour of booking
        /// </summary>
        public int Hour { get; set; }
        /// <summary>
        /// The individual bookings ID
        /// </summary>
        public int BookingID { get; set; }
        /// <summary>
        /// Comments for the booking
        /// </summary>
        public string Comment { get; set; }





        /// <summary>
        /// Constructors: Lucas Ingvardtsen
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="animalID"></param>
        /// <param name="date"></dato>
        /// <param name="hour"></p>
        /// <param name="bookingID"></param>
        /// <param name="comment"></param>
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
    

