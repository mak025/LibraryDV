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
    internal interface IActivityRepo
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
        public void EditActivity(Activity old, Activity newOne);

        /// <summary>
        /// Deletes an activity.
        /// </summary>
        /// <param name="act">The activity to remove.</param>
        public void DeleteActivity(Activity act);

        /// <summary>
        /// Retrieves an activity by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the activity.</param>
        /// <returns>The activity if found; otherwise, null.</returns>
        public Activity GetActivity(int id);

        /// <summary>
        /// Gets all activities.
        /// </summary>
        /// <returns>A list of all activities.</returns>
        public List<Activity> GetAllActivities();
    }
}
