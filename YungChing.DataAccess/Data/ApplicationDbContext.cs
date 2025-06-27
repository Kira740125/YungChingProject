using Microsoft.EntityFrameworkCore;
using YungChing.Models;

namespace YungChing.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Large"},
                new Category { Id = 2, Name = "Medium"},
                new Category { Id = 3, Name = "Small"}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "A House",
                    Address = "123 Main St, Springfield, USA",
                    Description = "Foreign House",
                    Price = 90000,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "B House",
                    Address = "456 Elm St, HsinChu, Taiwan",
                    Description = "Local House",
                    Price = 50000,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "C House",
                    Address = "789 Oak St, Taipei, Taiwan",
                    Description = "Local House",
                    Price = 40000,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Title = "B House",
                    Address = "101 Pine St, Taichung, Taiwan",
                    Description = "Local House",
                    Price = 30000,
                    CategoryId = 1
                }
                );
        }
    }
}
