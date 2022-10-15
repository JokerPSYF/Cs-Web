using ForumApp.Data.Configure;
using ForumApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext
            (DbContextOptions<ForumAppDbContext> options)
            : base(options)
        {
            this.Database.Migrate(); 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration<Post>(new PostConfiguration());

            base.OnModelCreating(builder);

        }
        public DbSet<Post> Posts { get; set; }
    }
}
