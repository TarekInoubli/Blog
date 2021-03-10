using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared
{
    /// <summary>
    /// Stores the user information, including username and password.
    /// </summary>
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// User email
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// User profile
        /// - 0 : Guest
        /// - 1 : Administrator
        /// </summary>
        public int Profile { get; set; }
    }
}
