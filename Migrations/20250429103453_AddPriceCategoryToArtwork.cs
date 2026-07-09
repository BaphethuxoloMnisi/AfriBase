using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker2.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceCategoryToArtwork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Artworks",
                newName: "Category");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Artworks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "Id", "Category", "Description", "Price", "Title" },
                values: new object[] { 1, "Painting", "This is a seeded artwork for testing bids.", 1500m, "Sample Artwork" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Artworks");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Artworks",
                newName: "ImageUrl");
        }
    }
}
