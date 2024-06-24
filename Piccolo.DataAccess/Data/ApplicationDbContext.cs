using Microsoft.EntityFrameworkCore;
using Piccolo.Models;

namespace Piccolo.DataAccess.Data
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
                new Category { Id=1, Name="Pizza", DisplayOrder=1},
                new Category { Id = 2, Name = "Calzone", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Piadina", DisplayOrder = 3 }
                );
        }
    }
}
