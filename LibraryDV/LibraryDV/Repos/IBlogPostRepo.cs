using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    internal interface IBlogPostRepo
    {
        public void CreateBlogPost(BlogPost blogpost);

        public void DeleteBlogPost(BlogPost blogpost);

        public List<BlogPost> GetAllBlogPosts();
    }
}
