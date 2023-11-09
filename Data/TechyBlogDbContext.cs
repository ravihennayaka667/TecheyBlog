using Microsoft.EntityFrameworkCore;
using TecheyBlog.Models.Domain;

namespace TecheyBlog.Data
{
    public class TechyBlogDbContext : DbContext
    {
        public TechyBlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
