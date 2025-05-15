using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    internal class Activity
    {
        public static int ActID { get; set; } = 1;
        public string ActTitle { get; set; }
        public string Text { get; set; }
        public string ImgPath { get; set; }
        public DateOnly ActDate { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }


        public Activity (string title, string text, string imgPath, DateOnly date, int start, int end)
        {
            ActTitle = title;
            Text = text;
            ImgPath = imgPath;
            ActDate = date;
            StartHour = start;
            EndHour = end;
            ActID++;
        }
    }
}
