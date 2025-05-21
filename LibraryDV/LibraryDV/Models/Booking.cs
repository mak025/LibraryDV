using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models

{
    ///Lucas Ingvardtsen
    /// <summary>
    /// Represents a base class for bookings with common properties.
    /// </summary>
    public class Booking
    {
        /// <summary>
        /// Static variable to keep track of the next ID
        /// </summary>
        static int _staticID = 1;
        /// <summary>
        /// Gets or sets the users ID.
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Gets or sets the animals ID.
        /// </summary>
        public int AnimalID { get; set; }
        /// <summary>
        /// Gets or sets the date of booking.
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// Gets or sets the hour of booking
        /// </summary>
        public int Hour { get; set; }
        /// <summary>
        /// Gets or sets the booking ID.
        /// </summary>
        public int BookingID { get; set; }
        /// <summary>
        /// Gets or sets the comment for the booking
        /// </summary>
        public string Comment { get; set; }




        ///Lucas Ingvardtsen
        /// <summary>
        /// Constructors for bookings
        /// </summary>
        public Booking(int userID, int animalID, DateOnly date, int hour, string comment)
        {
            UserID = userID;
            AnimalID = animalID;
            Date = date;
            Hour = hour;
            BookingID = _staticID++; //Increment the static ID for each new booking
            Comment = comment;
        }
    }
}
    

