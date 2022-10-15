using ForumApp.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.ViewModels
{
    public class PostViewModel
    {
        [Key]
        [Comment("Post id")]
        [UIHint("hidden")]
        public int Id { get; set; }

        [Comment("Title of post")]
        [Required(ErrorMessage = "Полето {0} е задалжително")]
        [Display(Name = "Заглавие")]
        [StringLength(DataConstants.Post.TitleMax, MinimumLength = DataConstants.Post.TitleMin, ErrorMessage = "Полето {0} трябва да е междъ {2} и {1} символа")]
        public string Title { get; set; } = null!;

        [Comment("Content of post")]
        [Required(ErrorMessage = "Полето {0} е задалжително")]
        [Display(Name = "Съдържание")]
        [StringLength(DataConstants.Post.ContentMax, MinimumLength = DataConstants.Post.ContentMin, ErrorMessage = "Полето {0} трябва да е между {2} и {1} символа")]
        public string Content { get; set; } = null!;
    }
}
