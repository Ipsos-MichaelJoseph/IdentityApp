using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Watersports", "Kayak", 275m },
                    { 2L, "Watersports", "Lifejacket", 48.99m },
                    { 3L, "Football", "Ball", 19.50m },
                    { 4L, "Football", "Corner Flags", 34.99m },
                    { 5L, "Football", "Stadium", 88.99m },
                    { 6L, "Football", "Baseball Cap", 21.99m },
                    { 7L, "Football", "Scarf", 12.99m },
                    { 8L, "Chess", "Chair", 46.99m },
                    { 9L, "Chess", "Human-sized Chess Board", 75m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
