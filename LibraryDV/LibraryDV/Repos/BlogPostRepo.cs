using System;
using System.Collections.Generic;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    /// <summary>
    /// Repository class for managing blog posts.
    /// </summary>
    internal class BlogPostRepo : IBlogPostRepo
    {
        private IBlogPostRepo _blogPostInterface;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostRepo"/> class.
        /// </summary>
        /// <param name="blogPostInterface">The blog post repository interface.</param>
        public BlogPostRepo(IBlogPostRepo blogPostInterface)
        {
            _blogPostInterface = blogPostInterface;
        }

        /// <summary>
        /// Creates a new blog post.
        /// </summary>
        /// <param name="blogpost">The blog post object to be created.</param>
        public void CreateBlogPost(BlogPost blogpost)
        {
            _blogPostInterface.CreateBlogPost(blogpost);
        }

        /// <summary>
        /// Deletes a blog post by ID.
        /// </summary>
        /// <param name="id">The ID of the blog post to delete.</param>
        public void DeleteBlogPost(int id)
        {
            _blogPostInterface.DeleteBlogPost(id);
        }

        /// <summary>
        /// Retrieves all blog posts.
        /// </summary>
        /// <returns>A list of all blog posts.</returns>
        public List<BlogPost> GetAllBlogPosts()
        {
            return _blogPostInterface.GetAllBlogPosts();
        }
    }
}