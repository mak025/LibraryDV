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
    /// Repository for managing activities.
    /// </summary>
    internal class ActivityRepo : IActivityRepo
    {
        /// <summary>
        /// List of activities.
        /// </summary>
        private List<Activity> _activities = new List<Activity>();

        /// <summary>
        /// Creates a new activity and adds it to the list.
        /// </summary>
        /// <param name="act">The activity to add.</param>
        public void CreateActivity(Activity act)
        {
            _activities.Add(act);
        }

        /// <summary>
        /// Edits an existing activity.
        /// </summary>
        /// <param name="old">The existing activity.</param>
        /// <param name="newOne">The updated activity details.</param>
        public void EditActivity(Activity old, Activity newOne)
        {
            old.ActivityTitle = newOne.ActivityTitle;
            old.Text = newOne.Text;
            old.ImgPath = newOne.ImgPath;
            old.ActivityDate = newOne.ActivityDate;
            old.StartHour = newOne.StartHour;
            old.EndHour = newOne.EndHour;
        }

        /// <summary>
        /// Deletes an activity from the list.
        /// </summary>
        /// <param name="activityID">The activity to remove.</param>
        public void DeleteActivity(int activityID)
        {
            _activities.Remove(_activities.FirstOrDefault(b => b.ActivityID == activityID);
        }

        /// <summary>
        /// Retrieves an activity by its ID.
        /// </summary>
        /// <param name="actID">The ID of the activity.</param>
        /// <returns>The activity if found; otherwise, null.</returns>
        public Activity GetActivity(int actID)
        {
            foreach (Activity activity in _activities)
            {
                if (activity.ActivityID == actID)
                {
                    return activity;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets all activities.
        /// </summary>
        /// <returns>A list of all activities.</returns>
        public List<Activity> GetAllActivities()
        {
            return _activities;
        }
    }
}
