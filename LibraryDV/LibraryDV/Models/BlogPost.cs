using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDV.Models
{
    public class BlogPost
    {
        ///Egil

        /// <summary>
        /// title of the blog post
        /// </summary>
        public required string Title { get; set; }
        /// <summary>
        /// filepath to the image in the blogpost
        /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
        /// main text in the blogpost
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Constructor for BlogPost
        /// </summary>
        /// <param name="title">title for blogpost</param>
        /// <param name="imgPath">filepath for image in blogpost</param>
        /// <param name="text">main text</param>
        public BlogPost(string title, string imgPath, string text)
        {
            Title = title;
            ImgPath = imgPath;
            Text = text;
        }
        
    }
}
