using BlazorBlog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Client.Services
{
    /// <summary>
    /// IBlogService
    /// </summary>
    interface IBlogService
    {
        /// <summary>
        /// Get all blog posts.
        /// </summary>
        /// <returns></returns>
        Task<List<BlogPost>> GetBlogPosts();

        /// <summary>
        /// Get a single blog post by url.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        Task<BlogPost> GetBlogPostByUrl(string url);

        /// <summary>
        /// Create a new blog post
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BlogPost> CreateNewBlogPost(BlogPost request);
    }
}
