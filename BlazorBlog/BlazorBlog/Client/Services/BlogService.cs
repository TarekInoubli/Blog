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
        public async Task<Post> CreateNewBlogPost(Post request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Blog", request);
            return await result.Content.ReadFromJsonAsync<Post>();
        }

        /// <summary>
        /// Get blog post by url
        /// </summary>
        /// <param name="url">the url</param>
        /// <returns></returns>
        public async Task<Post> GetBlogPostByUrl(string url)
        {
            var result = await _httpClient.GetAsync($"api/Blog/{url}");

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var message = await result.Content.ReadAsStringAsync();
                return new Post { Title = message };
            }
            else
            {
                return await result.Content.ReadFromJsonAsync<Post>();
            }
        }

        /// <summary>
        /// Get all blog posts
        /// </summary>
        /// <returns></returns>
        public async Task<List<Post>> GetBlogPosts()
        {
            return await _httpClient.GetFromJsonAsync<List<Post>>("api/Blog");
        }

        /// <summary>
        /// Get post categories
        /// </summary>
        /// <returns></returns>
        public async Task<List<Category>> GetCategories()
        {
            return await _httpClient.GetFromJsonAsync<List<Category>>("api/Categories");
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>("api/Users");
        }
    }
}
