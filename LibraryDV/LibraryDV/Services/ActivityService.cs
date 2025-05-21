using System;
using System.Collections.Generic;
using LibraryDV.Repos;
using LibraryDV.Models;

namespace LibraryDV.Services
{
    /// <summary>
    /// Service class for managing activities.
    /// </summary>
    public class ActivityService
    {
        /// <summary>
        /// Repository interface for activity operations.
        /// </summary>
        private IActivityRepo _actInterface;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityService"/> class.
        /// </summary>
        /// <param name="iActivity">The activity repository interface.</param>
        public ActivityService(IActivityRepo iActivity)
        {
            _actInterface = iActivity;
        }

        /// <summary>
        /// Creates a new activity.
        /// </summary>
        /// <param name="act">The activity to add.</param>
        public void CreateActivity(string title, string text, string imgPath, DateOnly date, int start, int end)
        {
            _actInterface.CreateActivity(new Activity(title, text, imgPath, date, start, end));
        }

        /// <summary>
        /// Edits an existing activity.
        /// </summary>
        /// <param name="old">The original activity.</param>
        /// <param name="newOne">The updated activity details.</param>
        public void EditActivity(int oldID, string newTitle, string newText, string newImgPath, DateOnly newDate, int newStart, int newEnd)
        {
            _actInterface.EditActivity(oldID, newTitle, newText, newImgPath, newDate, newStart, newEnd);
        }

        /// <summary>
        /// Deletes an activity.
        /// </summary>
        /// <param name="act">The activity to remove.</param>
        public void DeleteActivity(int activityID)
        {
            _actInterface.DeleteActivity(activityID);
        }

        /// <summary>
        /// Retrieves an activity by its ID.
        /// </summary>
        /// <param name="activityID">The ID of the activity.</param>
        /// <returns>The activity if found; otherwise, null.</returns>
        public Activity GetActivity(int activityID)
        {
            return _actInterface.GetActivity(activityID);
        }

        /// <summary>
        /// Gets all activities.
        /// </summary>
        /// <returns>A list of all activities.</returns>
        public List<Activity> GetAllActivities()
        {
            return _actInterface.GetAllActivities();
        }
    }
}