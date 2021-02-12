using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

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
