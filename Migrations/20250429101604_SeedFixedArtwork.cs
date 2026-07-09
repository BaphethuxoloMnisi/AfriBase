using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker2.Migrations
{
    /// <inheritdoc />
    public partial class SeedFixedArtwork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartingPrice",
                table: "Artworks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "StartingPrice",
                table: "Artworks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
