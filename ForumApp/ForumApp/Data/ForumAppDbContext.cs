using ForumApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumAppDbContext : DbContext
    {
        private Post FirstPost { get; set; }

        private Post SecondPost { get; set; }

        private Post ThirdPost { get; set; }


        public ForumAppDbContext
            (DbContextOptions<ForumAppDbContext> options)
            : base(options)
        {
            this.Database.Migrate(); 

        }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Post>();

            base.OnModelCreating(builder);

            SeedPosts();
            builder
                .Entity<Post>()
                .HasData(this.FirstPost,
                         this.SecondPost,
                         this.ThirdPost);
            base.OnModelCreating(builder);
        }

        private void SeedPosts()
        {
            this.FirstPost = new Post()
            {
                Id = 1,
                Title = "My first post",
                Content = "My first content"
            };
            this.SecondPost = new Post()
            {
                Id = 2,
                Title = "My second post",
                Content = "My second content"
            };
            this.ThirdPost = new Post()
            {
                Id = 3,
                Title = "My third post",
                Content = "My third content"
            };
        }
    }
}
