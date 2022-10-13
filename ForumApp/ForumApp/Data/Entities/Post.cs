using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Entities
{
    public class Post
    {
        /// <summary>
        /// Post id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Title of post
        /// </summary>
        [Required]
        [StringLength(DataConstants.Post.TitleMax, MinimumLength = DataConstants.Post.TitleMin)]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Content of post
        /// </summary>
        [Required]
        [StringLength(DataConstants.Post.ContentMax, MinimumLength = DataConstants.Post.ContentMin)]
        public string Content { get; set; } = null!;

        /// <summary>
        /// Boolean is deleted or not
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
}
