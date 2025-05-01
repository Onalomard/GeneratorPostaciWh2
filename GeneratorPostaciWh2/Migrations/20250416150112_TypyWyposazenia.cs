using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneratorPostaciWh2.Migrations
{
    /// <inheritdoc />
    public partial class TypyWyposazenia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cechy",
                table: "Wyposazenie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LokalizacjaCiala",
                table: "Wyposazenie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Obrazenia",
                table: "Wyposazenie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PunktyZbroji",
                table: "Wyposazenie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Typ",
                table: "Wyposazenie",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cechy",
                table: "Wyposazenie");

            migrationBuilder.DropColumn(
                name: "LokalizacjaCiala",
                table: "Wyposazenie");

            migrationBuilder.DropColumn(
                name: "Obrazenia",
                table: "Wyposazenie");

            migrationBuilder.DropColumn(
                name: "PunktyZbroji",
                table: "Wyposazenie");

            migrationBuilder.DropColumn(
                name: "Typ",
                table: "Wyposazenie");
        }
    }
}
