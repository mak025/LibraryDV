using System;
using System.Collections.Generic;
using LibraryDV.Repos;
using LibraryDV.Models;

namespace LibraryDV.Services
{
    /// <summary>
    /// Service class for managing blog posts.
    /// </summary>
    internal class BlogPostService
    {
        private IBlogPostRepo _blogPostInterface;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostService"/> class.
        /// </summary>
        /// <param name="blogPostInterface">The blog post repository interface.</param>
        public BlogPostService(IBlogPostRepo blogPostInterface)
        {
            _blogPostInterface = blogPostInterface;
        }

        /// <summary>
        /// Creates a new blog post.
        /// </summary>
        /// <param name="title">The title of the blog post.</param>
        /// <param name="imgPath">The image path for the blog post.</param>
        /// <param name="text">The content of the blog post.</param>
        public void CreateBlogPost(string title, string imgPath, string text)
        {
            BlogPost blogPost = new BlogPost(title, imgPath, text)
            {
                Title = title,
                Text = text
            };
            _blogPostInterface.CreateBlogPost(blogPost);
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