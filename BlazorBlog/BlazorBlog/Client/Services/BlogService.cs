using BlazorBlog.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBlog.Client.Services
{
    /// <summary>
    /// Blog Services
    /// </summary>
    public class BlogService : IBlogService
    {
        /// <summary>
        /// httpclient object
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpClient"></param>
        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Create a new blog post
        /// </summary>
        /// <param name="request">the blog post to be created</param>
        /// <returns></returns>
        public async Task<BlogPost> CreateNewBlogPost(BlogPost request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Blog", request);
            return await result.Content.ReadFromJsonAsync<BlogPost>();
        }

        /// <summary>
        /// Get blog post by url
        /// </summary>
        /// <param name="url">the url</param>
        /// <returns></returns>
        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var result = await _httpClient.GetAsync($"api/Blog/{url}");

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var message = await result.Content.ReadAsStringAsync();
                Console.WriteLine(message);
                return new BlogPost { Title = message };
            }
            else
            {
                return await result.Content.ReadFromJsonAsync<BlogPost>();
            }
        }

        /// <summary>
        /// Get all blog posts
        /// </summary>
        /// <returns></returns>
        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await _httpClient.GetFromJsonAsync<List<BlogPost>>("api/Blog");
        }

    }
}
