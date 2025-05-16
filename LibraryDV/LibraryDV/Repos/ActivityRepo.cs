using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    internal class ActivityRepo : IActivityRepo
    {
        private List<Activity> _activities = new List<Activity>();

        public void CreateActivity(Activity act)
        {
            _activities.Add(act);
        }

        public void EditActivity(Activity old, Activity newOne)
        {
            old.ActTitle = newOne.ActTitle;
            old.Text = newOne.Text;
            old.ImgPath = newOne.ImgPath;
            old.ActDate = newOne.ActDate;
            old.StartHour = newOne.StartHour;
            old.EndHour = newOne.EndHour;
        }

        public void DeleteActivity(Activity act)
        {
            _activities.Remove(act);
        }

        public Activity GetActivity(int actID) 
        {
            foreach(Activity activity in _activities)
            {
                if (activity.ActID == actID)
                { return activity; }
            }
            return null;
        }

        public List<Activity> GetAllActivities()
        {
            return _activities;
        }
    }
}
