using BlazorBlog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost
            {
                Url = "new-tutorial",
                Title = "A New Tutorial about Blazor with web API",
                Description = "This is a new tutorial, showing you how to build a web blog using Blazor",
                Content ="What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."

            },
            new BlogPost
            {
                Url="first-post",
                Title = "My First Blog Post with web API",
                Description = "This is a new tutorial, showing you how to blog your first post",
                Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."

            }
        };

        [HttpGet]
        public ActionResult<List<BlogPost>> GimmeAllBlogPosts()
        {
            return Ok(Posts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GimmeThatBlogPost(string url)
        {
            var post = Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
            if (post == null)
            {
                return NotFound("This post could not be found!");
            }

            return Ok(post);
        }
    }
}
