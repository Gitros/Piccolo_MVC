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
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name="Pizza", DisplayOrder=1},
                new Category { Id = 2, Name = "Calzone", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Piadina", DisplayOrder = 3 }
                );

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Type = "Vege"},
                new ProductType { Id = 2, Type = "Ham / Parma ham"},
                new ProductType { Id = 3, Type = "Salami Napoli / Salami Picante"},
                new ProductType { Id = 4, Type = "Nduja" },
                new ProductType { Id = 5, Type = "Chicken" },
                new ProductType { Id = 6, Type = "Tuna / Salmon" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    Id = 1, 
                    Ingredients = "Sos pomidorowy, mozarella, bazylia", 
                    PriceSmall = 28, 
                    PriceBig=40,
                    CategoryId= 1,
                    Position= 1,
                    ProductTypeId= 1,
                },
                new Product { 
                    Id = 2, 
                    Ingredients = "Sos pomidorowy, mozzarella, plastry świeżej mozzarelli, pomidorki koktajlowe, oliwki, bazylia", 
                    PriceSmall = 35, 
                    PriceBig = 48,
                    CategoryId = 1,
                    Position = 2,
                    ProductTypeId = 1,
                },
                new Product
                {
                    Id = 3,
                    Ingredients = "Sos pomidorowy, mozzarella, szynka parmeńska, pomidorki koktajlowe, parmezan, rukola",
                    PriceSmall = 40,
                    PriceBig = 54,
                    CategoryId = 1,
                    Position = 3,
                    ProductTypeId = 2
                },
                new Product
                {
                    Id = 4,
                    Ingredients = "Biały sos, mozzarella, oliwki, szynka parmeńska, parmezan, rukola",
                    PriceSmall = 39,
                    PriceBig = 52,
                    CategoryId = 1,
                    Position = 4,
                    ProductTypeId = 2,
                },
                new Product
                {
                    Id = 5,
                    Ingredients = "Sos pomidorowy, mozzarella, salami napoli, suszone pomidory, cebula, bazylia",
                    PriceSmall = 39,
                    PriceBig = 53,
                    CategoryId = 1,
                    Position = 5,
                    ProductTypeId = 3,
                },
                new Product
                {
                    Id = 6,
                    Ingredients = "Sos pomidorowy, mozzarella, salami napoli / salami picante, pieczarki, bazylia",
                    PriceSmall = 35,
                    PriceBig = 48,
                    CategoryId = 1,
                    Position = 6,
                    ProductTypeId = 3,
                },
                new Product
                {
                    Id = 7,
                    Ingredients = "Sos pomidorowy, mozzarella, salami picante, ananas, jalapeno, karmelizowana cebula",
                    PriceSmall = 38,
                    PriceBig = 51,
                    CategoryId = 1,
                    Position = 7,
                    ProductTypeId = 3,
                },
                new Product
                {
                    Id = 8,
                    Ingredients = "Sos pomidorowy, mozzarella, salami picante, mascarpone, gorgonzola, oliwki, bazylia",
                    PriceSmall = 40,
                    PriceBig = 54,
                    CategoryId = 1,
                    Position = 8,
                    ProductTypeId = 3,
                },
                new Product
                {
                    Id = 9,
                    Ingredients = "Sos pomidorowy, mozzarella, salami napoli, pieczona papryka, czerwona cebula",
                    PriceSmall = 35,
                    PriceBig = 50,
                    CategoryId = 1,
                    Position = 9,
                    ProductTypeId = 3,
                }
                );
        }
    }
}
