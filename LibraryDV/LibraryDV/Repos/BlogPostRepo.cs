using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    internal class BlogPostRepo : IBlogPostRepo
    {
        private IBlogPostRepo _blogPostInterface;

        public BlogPostRepo(IBlogPostRepo blogPostInterface)
        {
            _blogPostInterface = blogPostInterface;
        }

        public void CreateBlogPost(BlogPost blogpost)
        {
            _blogPostInterface.CreateBlogPost(blogpost);
        }

        public void DeleteBlogPost(BlogPost blogpost)
        {
            _blogPostInterface.DeleteBlogPost(blogpost);
        }

        public List<BlogPost> GetAllBlogPosts()
        {
            return _blogPostInterface.GetAllBlogPosts();
        }
    }
}
