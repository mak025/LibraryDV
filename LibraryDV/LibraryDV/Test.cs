using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Repos;
using LibraryDV.Services;

namespace LibraryDV
{
    class Test
    {
        private ActivityService _activityService;

        // Constructor to initialize the ActivityService
        public Test(ActivityService actService)
        {
            _activityService = actService;
        }

        public void RunTest()
        {
            // Correctly call the CreateActivity method inside a method
            _activityService.CreateActivity("Title", "text", "imgpath", DateOnly.FromDateTime(DateTime.Now), 12, 14);
        }
    }
}
