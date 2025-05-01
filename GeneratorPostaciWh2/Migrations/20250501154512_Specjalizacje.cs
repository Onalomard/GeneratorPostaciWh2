using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneratorPostaciWh2.Migrations
{
    /// <inheritdoc />
    public partial class Specjalizacje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specjalizacja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UmiejetnoscId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specjalizacja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specjalizacja_Umiejetnosci_UmiejetnoscId",
                        column: x => x.UmiejetnoscId,
                        principalTable: "Umiejetnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specjalizacja_UmiejetnoscId",
                table: "Specjalizacja",
                column: "UmiejetnoscId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specjalizacja");
        }
    }
}
