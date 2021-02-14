using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared
{
    /// <summary>
    /// stores post tag frequency information. 
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Tag ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique tag name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The number of times that the tag appears in posts
        /// </summary>
        [Required]
        public int Frequency { get; set; }
    }
}
