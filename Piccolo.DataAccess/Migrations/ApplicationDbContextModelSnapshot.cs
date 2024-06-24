﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Piccolo.DataAccess.Data;

#nullable disable

namespace Piccolo.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Piccolo.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Calzone"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Piadina"
                        });
                });

            modelBuilder.Entity("Piccolo.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceBig")
                        .HasColumnType("int");

                    b.Property<int>("PriceSmall")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ingredients = "Sos pomidorowy, mozarella, bazylia",
                            PriceBig = 40,
                            PriceSmall = 28
                        },
                        new
                        {
                            Id = 2,
                            Ingredients = "Sos pomidorowy, mozzarella, plastry świeżej mozzarelli, pomidorki koktajlowe, oliwki, bazylia",
                            PriceBig = 48,
                            PriceSmall = 35
                        },
                        new
                        {
                            Id = 3,
                            Ingredients = "Sos pomidorowy, mozzarella, szynka parmeńska, pomidorki koktajlowe, parmezan, rukola",
                            PriceBig = 54,
                            PriceSmall = 40
                        },
                        new
                        {
                            Id = 4,
                            Ingredients = "Biały sos, mozzarella, oliwki, szynka parmeńska, parmezan, rukola",
                            PriceBig = 52,
                            PriceSmall = 39
                        },
                        new
                        {
                            Id = 5,
                            Ingredients = "Sos pomidorowy, mozzarella, salami napoli, suszone pomidory, cebula, bazylia",
                            PriceBig = 53,
                            PriceSmall = 39
                        },
                        new
                        {
                            Id = 6,
                            Ingredients = "Sos pomidorowy, mozzarella, salami napoli / salami picante, pieczarki, bazylia",
                            PriceBig = 48,
                            PriceSmall = 35
                        },
                        new
                        {
                            Id = 7,
                            Ingredients = "Sos pomidorowy, mozzarella, salami picante, ananas, jalapeno, karmelizowana cebula",
                            PriceBig = 51,
                            PriceSmall = 38
                        },
                        new
                        {
                            Id = 8,
                            Ingredients = "Sos pomidorowy, mozzarella, salami picante, mascarpone, gorgonzola, oliwki, bazylia",
                            PriceBig = 54,
                            PriceSmall = 40
                        },
                        new
                        {
                            Id = 9,
                            Ingredients = "Sos pomidorowy, mozzarella, salami napoli, pieczona papryka, czerwona cebula",
                            PriceBig = 50,
                            PriceSmall = 35
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
