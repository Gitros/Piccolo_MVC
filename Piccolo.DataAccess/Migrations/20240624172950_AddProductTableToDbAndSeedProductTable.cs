using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Piccolo.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTableToDbAndSeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceSmall = table.Column<int>(type: "int", nullable: false),
                    PriceBig = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Ingredients", "PriceBig", "PriceSmall" },
                values: new object[,]
                {
                    { 1, "Sos pomidorowy, mozarella, bazylia", 40, 28 },
                    { 2, "Sos pomidorowy, mozzarella, plastry świeżej mozzarelli, pomidorki koktajlowe, oliwki, bazylia", 48, 35 },
                    { 3, "Sos pomidorowy, mozzarella, szynka parmeńska, pomidorki koktajlowe, parmezan, rukola", 54, 40 },
                    { 4, "Biały sos, mozzarella, oliwki, szynka parmeńska, parmezan, rukola", 52, 39 },
                    { 5, "Sos pomidorowy, mozzarella, salami napoli, suszone pomidory, cebula, bazylia", 53, 39 },
                    { 6, "Sos pomidorowy, mozzarella, salami napoli / salami picante, pieczarki, bazylia", 48, 35 },
                    { 7, "Sos pomidorowy, mozzarella, salami picante, ananas, jalapeno, karmelizowana cebula", 51, 38 },
                    { 8, "Sos pomidorowy, mozzarella, salami picante, mascarpone, gorgonzola, oliwki, bazylia", 54, 40 },
                    { 9, "Sos pomidorowy, mozzarella, salami napoli, pieczona papryka, czerwona cebula", 50, 35 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
