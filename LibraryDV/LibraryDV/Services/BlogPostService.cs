using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Repos;
using LibraryDV.Models;

namespace LibraryDV.Services
{
    internal class BlogPostService
    {
        private IBlogPostRepo _blogPostInterface;

        public BlogPostService(IBlogPostRepo blogPostInterface) 
        { 
            _blogPostInterface = blogPostInterface;
        }

        public void CreateBlogPost(string title, string imgPath, string text)
        {
            _blogPostInterface.CreateBlogPost(new BlogPost(title, imgPath, text));
        }
    }
}
