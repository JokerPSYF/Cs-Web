using ForumApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForumApp.Data.Configure
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            List<Post> posts = GetPost();
            builder.HasData(posts);
        }

        private List<Post> GetPost()
        {
            return new List<Post>() {
             new Post()
            {
                Id = 1,
                Title = "My first post",
                Content = "My first content"
            },
             new Post()
            {
                Id = 2,
                Title = "My second post",
                Content = "My second content"
            },
             new Post()
            {
                Id = 3,
                Title = "My third post",
                Content = "My third content"
            }};
        }
    }
}
