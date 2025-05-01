using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneratorPostaciWh2.Migrations
{
    /// <inheritdoc />
    public partial class Mag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Mag",
                table: "Profesje",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mag",
                table: "Postacie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mag",
                table: "Profesje");

            migrationBuilder.DropColumn(
                name: "Mag",
                table: "Postacie");
        }
    }
}
