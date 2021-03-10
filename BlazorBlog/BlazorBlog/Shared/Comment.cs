using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared
{
    /// <summary>
    /// Stores the post comment information.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  The comment content in plain text format
        /// </summary>
        [Required]
        public string Content { get; set; }

        /// <summary>
        /// Status of the comment
        /// - 1 : Not approved
        /// - 2 : Approved
        /// </summary>
        [Required]
        public int Status { get; set; }

        /// <summary>
        /// The author name
        /// </summary>
        [Required]
        public string Author { get; set; }

        /// <summary>
        /// The author email
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// The author website url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        ///  Created date
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Related post
        /// </summary>
        public int PostID { get; set; }

        /// <summary>
        /// Related post
        /// </summary>
        public Post Post { get; set; }
    }
}
