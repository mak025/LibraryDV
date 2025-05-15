using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public class BlogPost
    {
        /// <summary>
        /// Title of the blog post, forfatter: Egil
        /// </summary>
        public required string Title { get; set; }
        public string ImgPath { get; set; }
        public required string Text { get; set; }

        /// <summary>
        /// Constructor for BlogPost, forfatter: Egil
        /// </summary>
        /// <param name="title">overskrift til blogpost</param>
        /// <param name="imgPath">filsti til billede</param>
        /// <param name="text">brødtekst</param>
        public BlogPost(string title, string imgPath, string text)
        {
            Title = title;
            ImgPath = imgPath;
            Text = text;
        }
        
    }
}
