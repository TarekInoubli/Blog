using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared
{
    /// <summary>
    /// Stores a post category information
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Category ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Category description
        /// </summary>
        public string Description { get; set; }
    }
}
