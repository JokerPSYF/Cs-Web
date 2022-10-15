using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Entities
{
    public class Post
    {
        [Comment("Post id")]
        [Key]
        public int Id { get; set; }

        [Comment("Title of post")]
        [Required]
        [StringLength(DataConstants.Post.TitleMax, MinimumLength = DataConstants.Post.TitleMin)]
        public string Title { get; set; } = null!;

        [Comment("Content of post")]
        [Required]
        [StringLength(DataConstants.Post.ContentMax, MinimumLength = DataConstants.Post.ContentMin)]
        public string Content { get; set; } = null!;

        [Comment("Boolean is deleted or not")]
        public bool IsActive { get; set; } = true;
    }
}
