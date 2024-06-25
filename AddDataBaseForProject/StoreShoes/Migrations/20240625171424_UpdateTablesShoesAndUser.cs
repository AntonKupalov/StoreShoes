using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreShoes.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablesShoesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Users",
                type: "text",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Production",
                table: "Shoes",
                type: "text",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Shoes",
                type: "text",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Production",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Shoes");
        }
    }
}
