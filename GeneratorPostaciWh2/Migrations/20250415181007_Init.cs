using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneratorPostaciWh2.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ww = table.Column<int>(type: "int", nullable: false),
                    Us = table.Column<int>(type: "int", nullable: false),
                    K = table.Column<int>(type: "int", nullable: false),
                    Odp = table.Column<int>(type: "int", nullable: false),
                    Zr = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Sw = table.Column<int>(type: "int", nullable: false),
                    Ogd = table.Column<int>(type: "int", nullable: false),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    A = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rasy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ww = table.Column<int>(type: "int", nullable: false),
                    Us = table.Column<int>(type: "int", nullable: false),
                    K = table.Column<int>(type: "int", nullable: false),
                    Odp = table.Column<int>(type: "int", nullable: false),
                    Zr = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Sw = table.Column<int>(type: "int", nullable: false),
                    Ogd = table.Column<int>(type: "int", nullable: false),
                    Hp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rasy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Umiejetnosci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Umiejetnosci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wyposazenie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wyposazenie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zdolnosci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zdolnosci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Postacie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RasaId = table.Column<int>(type: "int", nullable: false),
                    ProfesjaId = table.Column<int>(type: "int", nullable: false),
                    WW = table.Column<int>(type: "int", nullable: false),
                    US = table.Column<int>(type: "int", nullable: false),
                    K = table.Column<int>(type: "int", nullable: false),
                    Odp = table.Column<int>(type: "int", nullable: false),
                    Zr = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Sw = table.Column<int>(type: "int", nullable: false),
                    Ogd = table.Column<int>(type: "int", nullable: false),
                    A = table.Column<int>(type: "int", nullable: false),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    Pp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postacie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postacie_Profesje_ProfesjaId",
                        column: x => x.ProfesjaId,
                        principalTable: "Profesje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postacie_Rasy_RasaId",
                        column: x => x.RasaId,
                        principalTable: "Rasy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfesjaUmiejetnosc",
                columns: table => new
                {
                    ProfesjeId = table.Column<int>(type: "int", nullable: false),
                    UmiejetnosciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesjaUmiejetnosc", x => new { x.ProfesjeId, x.UmiejetnosciId });
                    table.ForeignKey(
                        name: "FK_ProfesjaUmiejetnosc_Profesje_ProfesjeId",
                        column: x => x.ProfesjeId,
                        principalTable: "Profesje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesjaUmiejetnosc_Umiejetnosci_UmiejetnosciId",
                        column: x => x.UmiejetnosciId,
                        principalTable: "Umiejetnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RasaUmiejetnosc",
                columns: table => new
                {
                    RasyId = table.Column<int>(type: "int", nullable: false),
                    UmiejetnosciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasaUmiejetnosc", x => new { x.RasyId, x.UmiejetnosciId });
                    table.ForeignKey(
                        name: "FK_RasaUmiejetnosc_Rasy_RasyId",
                        column: x => x.RasyId,
                        principalTable: "Rasy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RasaUmiejetnosc_Umiejetnosci_UmiejetnosciId",
                        column: x => x.UmiejetnosciId,
                        principalTable: "Umiejetnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfesjaWyposazenie",
                columns: table => new
                {
                    ProfesjeId = table.Column<int>(type: "int", nullable: false),
                    WyposazenieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesjaWyposazenie", x => new { x.ProfesjeId, x.WyposazenieId });
                    table.ForeignKey(
                        name: "FK_ProfesjaWyposazenie_Profesje_ProfesjeId",
                        column: x => x.ProfesjeId,
                        principalTable: "Profesje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesjaWyposazenie_Wyposazenie_WyposazenieId",
                        column: x => x.WyposazenieId,
                        principalTable: "Wyposazenie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfesjaZdolnosc",
                columns: table => new
                {
                    ProfesjeId = table.Column<int>(type: "int", nullable: false),
                    ZdolnosciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesjaZdolnosc", x => new { x.ProfesjeId, x.ZdolnosciId });
                    table.ForeignKey(
                        name: "FK_ProfesjaZdolnosc_Profesje_ProfesjeId",
                        column: x => x.ProfesjeId,
                        principalTable: "Profesje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesjaZdolnosc_Zdolnosci_ZdolnosciId",
                        column: x => x.ZdolnosciId,
                        principalTable: "Zdolnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RasaZdolnosc",
                columns: table => new
                {
                    RasyId = table.Column<int>(type: "int", nullable: false),
                    ZdolnosciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasaZdolnosc", x => new { x.RasyId, x.ZdolnosciId });
                    table.ForeignKey(
                        name: "FK_RasaZdolnosc_Rasy_RasyId",
                        column: x => x.RasyId,
                        principalTable: "Rasy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RasaZdolnosc_Zdolnosci_ZdolnosciId",
                        column: x => x.ZdolnosciId,
                        principalTable: "Zdolnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostacUmiejetnosc",
                columns: table => new
                {
                    PostacieId = table.Column<int>(type: "int", nullable: false),
                    UmiejetnosciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostacUmiejetnosc", x => new { x.PostacieId, x.UmiejetnosciId });
                    table.ForeignKey(
                        name: "FK_PostacUmiejetnosc_Postacie_PostacieId",
                        column: x => x.PostacieId,
                        principalTable: "Postacie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostacUmiejetnosc_Umiejetnosci_UmiejetnosciId",
                        column: x => x.UmiejetnosciId,
                        principalTable: "Umiejetnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostacWyposazenie",
                columns: table => new
                {
                    PostacieId = table.Column<int>(type: "int", nullable: false),
                    WyposazenieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostacWyposazenie", x => new { x.PostacieId, x.WyposazenieId });
                    table.ForeignKey(
                        name: "FK_PostacWyposazenie_Postacie_PostacieId",
                        column: x => x.PostacieId,
                        principalTable: "Postacie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostacWyposazenie_Wyposazenie_WyposazenieId",
                        column: x => x.WyposazenieId,
                        principalTable: "Wyposazenie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostacZdolnosc",
                columns: table => new
                {
                    PostacieId = table.Column<int>(type: "int", nullable: false),
                    ZdolnosciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostacZdolnosc", x => new { x.PostacieId, x.ZdolnosciId });
                    table.ForeignKey(
                        name: "FK_PostacZdolnosc_Postacie_PostacieId",
                        column: x => x.PostacieId,
                        principalTable: "Postacie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostacZdolnosc_Zdolnosci_ZdolnosciId",
                        column: x => x.ZdolnosciId,
                        principalTable: "Zdolnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postacie_ProfesjaId",
                table: "Postacie",
                column: "ProfesjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Postacie_RasaId",
                table: "Postacie",
                column: "RasaId");

            migrationBuilder.CreateIndex(
                name: "IX_PostacUmiejetnosc_UmiejetnosciId",
                table: "PostacUmiejetnosc",
                column: "UmiejetnosciId");

            migrationBuilder.CreateIndex(
                name: "IX_PostacWyposazenie_WyposazenieId",
                table: "PostacWyposazenie",
                column: "WyposazenieId");

            migrationBuilder.CreateIndex(
                name: "IX_PostacZdolnosc_ZdolnosciId",
                table: "PostacZdolnosc",
                column: "ZdolnosciId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesjaUmiejetnosc_UmiejetnosciId",
                table: "ProfesjaUmiejetnosc",
                column: "UmiejetnosciId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesjaWyposazenie_WyposazenieId",
                table: "ProfesjaWyposazenie",
                column: "WyposazenieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesjaZdolnosc_ZdolnosciId",
                table: "ProfesjaZdolnosc",
                column: "ZdolnosciId");

            migrationBuilder.CreateIndex(
                name: "IX_RasaUmiejetnosc_UmiejetnosciId",
                table: "RasaUmiejetnosc",
                column: "UmiejetnosciId");

            migrationBuilder.CreateIndex(
                name: "IX_RasaZdolnosc_ZdolnosciId",
                table: "RasaZdolnosc",
                column: "ZdolnosciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostacUmiejetnosc");

            migrationBuilder.DropTable(
                name: "PostacWyposazenie");

            migrationBuilder.DropTable(
                name: "PostacZdolnosc");

            migrationBuilder.DropTable(
                name: "ProfesjaUmiejetnosc");

            migrationBuilder.DropTable(
                name: "ProfesjaWyposazenie");

            migrationBuilder.DropTable(
                name: "ProfesjaZdolnosc");

            migrationBuilder.DropTable(
                name: "RasaUmiejetnosc");

            migrationBuilder.DropTable(
                name: "RasaZdolnosc");

            migrationBuilder.DropTable(
                name: "Postacie");

            migrationBuilder.DropTable(
                name: "Wyposazenie");

            migrationBuilder.DropTable(
                name: "Umiejetnosci");

            migrationBuilder.DropTable(
                name: "Zdolnosci");

            migrationBuilder.DropTable(
                name: "Profesje");

            migrationBuilder.DropTable(
                name: "Rasy");
        }
    }
}
