using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibraryDV.Models;
using LibraryDV.Repos.Converters;

namespace LibraryDV.Repos
{
    /// Marcus

    /// <summary>
    /// Repository for managing activities.
    /// </summary>
    public class ActivityRepo : IActivityRepo
    {
        /// <summary>
        /// List of activities.
        /// </summary>
        private List<Activity> _activities = new List<Activity>();

        /// <summary>
        /// Path to the JSON file where activities are stored.
        /// </summary>
        private readonly string _jsonFilePath = @"C:\LibraryDV\LibraryDV\LibraryDV\Json\Activities.json";
        
        public ActivityRepo ()
        {
            LoadFromJson(); 
        }

        /// <summary>
        /// Creates a new activity and adds it to the list.
        /// </summary>
        /// <param name="act">The activity to add.</param>
        public void CreateActivity(Activity act)
        {
            _activities.Add(act);
            SaveToJson();
        }

        /// <summary>
        /// Saves the list of activities to a JSON file.
        /// </summary>
        public void SaveToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = JsonSerializer.Serialize(_activities, options);
            File.WriteAllText(_jsonFilePath, json);
        }

        /// <summary>
        /// Loads activities from a JSON file into the list.
        /// </summary>
        public void LoadFromJson()
        {
            if (File.Exists(_jsonFilePath))
            {
                string json = File.ReadAllText(_jsonFilePath);
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
                var loadedActivities = JsonSerializer.Deserialize<List<Activity>>(json, options);
                if (loadedActivities != null)
                {
                    _activities = loadedActivities;
                }
            }
        }

        /// <summary>
        /// Edits an existing activity by changing all its properties to the new values provided.
        /// </summary>
        /// <param name="old">The existing activity.</param>
        /// <param name="newOne">The updated activity details.</param>
        public void EditActivity(int oldID, DateOnly newDate, string newTitle, string newText, string newImgPath, int newStart, int newEnd)
        {
            Activity old = GetActivity(oldID);
            old.Date = newDate;
            old.ActivityTitle = newTitle;
            old.Text = newText;
            old.ImgPath = newImgPath;
            old.StartHour = newStart;
            old.EndHour = newEnd;
            SaveToJson();
        }

        /// <summary>
        /// Deletes an activity from the list.
        /// </summary>
        /// <param name="activityID">The activity to remove.</param>
        public void DeleteActivity(int activityID)
        {
            var activityToDelete = _activities.FirstOrDefault(b => b.ActivityID == activityID);
            if (activityToDelete != null)
            {
                _activities.Remove(activityToDelete);
                SaveToJson();
            }
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
