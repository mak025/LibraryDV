using System;
using System.Collections.Generic;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    /// <summary>
    /// Interface for managing blog posts.
    /// </summary>
    public interface IBlogPostRepo
    {
        /// <summary>
        /// Creates a new blog post.
        /// </summary>
        /// <param name="blogpost">The blog post object to be created.</param>
        public void CreateBlogPost(BlogPost blogpost);

        /// <summary>
        /// Deletes a blog post by ID.
        /// </summary>
        /// <param name="id">The ID of the blog post to delete.</param>
        public void DeleteBlogPost(int id);

        /// <summary>
        /// Retrieves all blog posts.
        /// </summary>
        /// <returns>A list of all blog posts.</returns>
        public List<BlogPost> GetAllBlogPosts();
    }
}