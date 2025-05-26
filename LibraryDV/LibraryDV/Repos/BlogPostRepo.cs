using System;
using System.Collections.Generic;
using System.Text.Json;
using LibraryDV.Models;

namespace LibraryDV.Repos
{
    // Marcus, Magnus, Lucas & Egil

    /// <summary>
    /// Repository class for managing blog posts.
    /// </summary>
    public class BlogPostRepo : IBlogPostRepo
    {
        private List<BlogPost> _blogPosts = new List<BlogPost>();
        private readonly string jsonFilePath = @"C:\LibraryDV\LibraryDV\LibraryDV\Json\BlogPosts.json";

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostRepo"/> class.
        /// </summary>
        /// <param name="blogPostInterface">The blog post repository interface.</param>
        public BlogPostRepo()
        {
            LoadFromJson();
        }

        public void SaveToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = JsonSerializer.Serialize(_blogPosts, options);
            File.WriteAllText(jsonFilePath, json);
        }

        public void LoadFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var loadedBlogPosts = JsonSerializer.Deserialize<List<BlogPost>>(json, options);
                if (loadedBlogPosts != null)
                {
                    _blogPosts = loadedBlogPosts;
                }
            }
        }
        /// <summary>
        /// Creates a new blog post.
        /// </summary>
        /// <param name="blogpost">The blog post object to be created.</param>
        public void CreateBlogPost(BlogPost blogPost)
        {
            _blogPosts.Add(blogPost);
            SaveToJson();
        }

        /// <summary>
        /// Deletes a blog post by ID.
        /// </summary>
        /// <param name="id">The ID of the blog post to delete.</param>
        public void DeleteBlogPost(int id)
        {
            var blogPostToDelete = _blogPosts.FirstOrDefault(b => b.BlogPostID == id);
            _blogPosts.Remove(blogPostToDelete);
            SaveToJson();
        }

        /// <summary>
        /// Retrieves all blog posts.
        /// </summary>
        /// <returns>A list of all blog posts.</returns>
        public List<BlogPost> GetAllBlogPosts()
        {
            return _blogPosts;
        }
    }
}