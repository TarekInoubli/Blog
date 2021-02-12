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

        ///// <summary>
        ///// List of blog posts
        ///// </summary>
        //public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        //{
        //    new BlogPost
        //    {
        //        Url = "new-tutorial",
        //        Title = "A New Tutorial about Blazor",
        //        Description = "This is a new tutorial, showing you how to build a web blog using Blazor",
        //        Content ="What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."

        //    },
        //    new BlogPost
        //    {
        //        Url="first-post",
        //        Title = "My First Blog Post",
        //        Description = "This is a new tutorial, showing you how to blog your first post",
        //        Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."

        //    }
        //};
        ///// <summary>
        ///// Get blog post by url
        ///// </summary>
        ///// <param name="url">Post url</param>
        ///// <returns></returns>
        //public BlogPost GetBlogPostByUrl(string url)
        //{
        //    return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        //}

        ///// <summary>
        ///// Get all blog posts
        ///// </summary>
        ///// <returns></returns>
        //public List<BlogPost> GetBlogPosts()
        //{
        //    return Posts;
        //}
    }
}
