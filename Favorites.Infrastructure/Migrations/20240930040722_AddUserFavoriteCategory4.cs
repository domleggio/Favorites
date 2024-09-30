using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Favorites.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFavoriteCategory4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Favorite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_CategoryId",
                table: "Favorite",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_Category_CategoryId",
                table: "Favorite",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_Category_CategoryId",
                table: "Favorite");

            migrationBuilder.DropIndex(
                name: "IX_Favorite_CategoryId",
                table: "Favorite");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Favorite");
        }
    }
}
