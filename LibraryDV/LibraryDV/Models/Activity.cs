using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public class Activity
    {
        /// Marcus
        
        /// <summary>
        /// A static int that counts up everytime constructor is called, ensuring automated and unique ID value.
        /// </summary>
        private static int _staticID = 1;
        /// <summary>
        /// ID number, unique too each Activity
        /// </summary>
        public int ActivityID { get; set; }
        /// <summary>
        /// Date of activity
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// Title of Activity
        /// </summary>
        public string ActivityTitle { get; set; }
        /// <summary>
        /// Description of Activity
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Contains the path for the image file
        /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
        /// Date of Activity
        /// </summary>
        //public DateOnly ActivityDate { get; set; }
        /// <summary>
        /// Start hour for Activity
        /// </summary>
        public int StartHour { get; set; }
        /// <summary>
        /// End hour of Activity
        /// </summary>
        public int EndHour { get; set; }

        /// <summary>
        /// Constructor for Activity
        /// </summary>
        /// <param name="title">Title of new Activity</param>
        /// <param name="text">Description of new Activity</param>
        /// <param name="imgPath">Image Path of new Activity</param>
        /// <param name="date">Date of new Activity</param>
        /// <param name="start">Start hour of new Activity</param>
        /// <param name="end">End hour of new Activity</param>
        public Activity (DateOnly date, string title, string text, string imgPath, int start, int end)
        {
            ActivityID = _staticID++;
            Date = date;
            ActivityTitle = title;
            Text = text;
            ImgPath = imgPath;
            StartHour = start;
            EndHour = end;
        }
        public Activity()
        {
            // Parameterless constructor needed for deserialization
            ActivityID = _staticID++;

        }


    }
}
