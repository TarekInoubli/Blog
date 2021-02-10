using System;

namespace BlazorBlog.Shared
{
    /// <summary>
    /// BlogPost model.
    /// </summary>
    public class BlogPost
    {
        /// <summary>
        /// The post id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Post url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The post title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The post content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The post description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The post author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The post datetime
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Is the post already published?
        /// </summary>
        public bool IsPublished { get; set; } = true;

        /// <summary>
        /// Is the post already deleted?
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
