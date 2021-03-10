using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared
{
    /// <summary>
    /// Strores the blog post information.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// The post id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Post url
        /// </summary>
        [Required, StringLength(20, ErrorMessage = "Please use only 20 characters.")]
        public string Url { get; set; }

        /// <summary>
        /// The post image
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// The post title
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// The post description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The post content
        /// </summary>
        [Required]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// A list of comma-separated words categorizing the post.
        /// </summary>
        public string Tags { get; set; }

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

        /// <summary>
        /// The post author id
        /// </summary>
        public int AuthorID { get; set; }

        /// <summary>
        /// Post category id
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// The post author
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Post category
        /// </summary>
        public Category Category { get; set; }
    }
}
