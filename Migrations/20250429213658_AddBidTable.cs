using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker2.Migrations
{
    /// <inheritdoc />
    public partial class AddBidTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Artworks_ArtworkId",
                table: "Bids");

            migrationBuilder.DropIndex(
                name: "IX_Bids_ArtworkId",
                table: "Bids");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bids_ArtworkId",
                table: "Bids",
                column: "ArtworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Artworks_ArtworkId",
                table: "Bids",
                column: "ArtworkId",
                principalTable: "Artworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
