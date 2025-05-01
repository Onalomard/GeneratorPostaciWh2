using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneratorPostaciWh2.Migrations
{
    /// <inheritdoc />
    public partial class EnumPancerz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LokalizacjaCiala",
                table: "Wyposazenie",
                newName: "Lokalizacje");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lokalizacje",
                table: "Wyposazenie",
                newName: "LokalizacjaCiala");
        }
    }
}
