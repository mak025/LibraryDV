using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    internal interface IActivityRepo
    {
        public void CreateActivity(Activity act);

        public void EditActivity(Activity old, Activity newOne);

        public void DeleteActivity(Activity act);

        public Activity GetActivity(int id);

        public List<Activity> GetAllActivities(); 

    }
}
