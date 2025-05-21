using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    /// Marcus

    /// <summary>
    /// Interface for managing activities.
    /// </summary>
    public interface IActivityRepo
    {
        /// <summary>
        /// Creates a new activity.
        /// </summary>
        /// <param name="act">The activity to add.</param>
        public void CreateActivity(Activity act);

        /// <summary>
        /// Edits an existing activity.
        /// </summary>
        /// <param name="old">The existing activity.</param>
        /// <param name="newOne">The updated activity details.</param>
        public void EditActivity(int oldID, string newTitle, string newText, string newImgPath, DateOnly newDate, int newStart, int newEnd);

        /// <summary>
        /// Deletes an activity.
        /// </summary>
        /// <param name="act">The activity to remove.</param>
        public void DeleteActivity(int activityID);

        /// <summary>
        /// Retrieves an activity by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the activity.</param>
        /// <returns>The activity if found; otherwise, null.</returns>
        public Activity GetActivity(int activityID);

        /// <summary>
        /// Gets all activities.
        /// </summary>
        /// <returns>A list of all activities.</returns>
        public List<Activity> GetAllActivities();
    }
}
