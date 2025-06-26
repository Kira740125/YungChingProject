using Microsoft.EntityFrameworkCore;
using YungChingProject.Models;

namespace YungChingProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Large"},
                new Category { Id = 2, Name = "Medium"},
                new Category { Id = 3, Name = "Small"}
                );
        }
    }
}
