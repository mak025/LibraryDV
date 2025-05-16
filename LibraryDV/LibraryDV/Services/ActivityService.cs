using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Repos;
using LibraryDV.Models;

namespace LibraryDV.Services
{
    internal class ActivityService
    {
        private IActivityRepo _actInterface;

        public ActivityService(IActivityRepo iActivity)
        {
            _actInterface = iActivity;
        }

        public void Create(Activity act)
        {
            _actInterface.CreateActivity(act);
        }

        public void Edit(Activity old, Activity newOne)
        {
            _actInterface.EditActivity(old, newOne);
        }

        public void Delete(Activity act)
        {
            _actInterface.DeleteActivity(act);  
        }

        public Activity Get(int actID)
        {
            return _actInterface.GetActivity(actID);
        }

        public List<Activity> GetAll()
        {
            return _actInterface.GetAllActivities();
        }
    }
}
