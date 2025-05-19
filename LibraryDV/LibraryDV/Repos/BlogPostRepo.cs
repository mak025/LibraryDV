using System;
using System.Collections.Generic;
using LibraryDV.Models;
using System.Text.Json;

namespace LibraryDV.Repos
{
    /// <summary>
    /// Repository class for managing blog posts.
    /// </summary>
    public class BlogPostRepo : IBlogPostRepo
    {
        private IBlogPostRepo _blogPostInterface;
        private readonly string _filePath;
        private List<BlogPost> _BlogPosts = new List<BlogPost>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostRepo"/> class.
        /// </summary>
        /// <param name="blogPostInterface">The blog post repository interface.</param>
        public BlogPostRepo(IBlogPostRepo blogPostInterface)
        {
            _blogPostInterface = blogPostInterface;
            _filePath = "C:\\LibraryDV\\LibraryDV\\LibraryDV\\Json\\BlogPosts.json";
            _BlogPosts = LoadBlogPostsFromJson();
        }

        /// <summary>
        /// Creates a new blog post.
        /// </summary>
        /// <param name="blogpost">The blog post object to be created.</param>
        public void CreateBlogPost(BlogPost blogpost)
        {
            _blogPostInterface.CreateBlogPost(blogpost);
            SaveBlogPostsToJson();
        }

        /// <summary>
        /// Deletes a blog post by ID.
        /// </summary>
        /// <param name="id">The ID of the blog post to delete.</param>
        public void DeleteBlogPost(int id)
        {
            _blogPostInterface.DeleteBlogPost(id);
            SaveBlogPostsToJson();
        }

        /// <summary>
        /// Retrieves all blog posts.
        /// </summary>
        /// <returns>A list of all blog posts.</returns>
        public List<BlogPost> GetAllBlogPosts()
        {
            return _blogPostInterface.GetAllBlogPosts();
        }

        public List<BlogPost> LoadBlogPostsFromJson()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("JSON file not found. Returning an empty list.");
                return new List<BlogPost>();
            }

            // Read the JSON file
            var json = File.ReadAllText(_filePath);

            // Deserialize the JSON into a list of Boat objects
            var blogPosts = JsonSerializer.Deserialize<List<BlogPost>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return blogPosts ?? new List<BlogPost>();
        }

        private void SaveBlogPostsToJson()
        {
            // Serialize the list of boats to JSON and write it to the file
            var json = JsonSerializer.Serialize(_filePath, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}