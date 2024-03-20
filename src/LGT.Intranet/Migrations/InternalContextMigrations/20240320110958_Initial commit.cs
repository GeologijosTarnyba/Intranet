using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Intranet.Migrations.InternalContextMigrations
{
    /// <inheritdoc />
    public partial class Initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "I_IncidentoPozymis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_IncidentoPozymis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "I_SkundasType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_SkundasType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "K_Asmuo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_Asmuo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "K_Darboviete",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    OrderWeight = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_Darboviete", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "I_AptarnaujantiImone",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_AptarnaujantiImone", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_AptarnaujantiImone_K_Darboviete_ID",
                        column: x => x.ID,
                        principalTable: "K_Darboviete",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "I_InformacinisIsteklius",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Parent = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Priklauso = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_InformacinisIsteklius", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_InformacinisIsteklius_I_InformacinisIsteklius_Parent",
                        column: x => x.Parent,
                        principalTable: "I_InformacinisIsteklius",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_I_InformacinisIsteklius_K_Darboviete_Priklauso",
                        column: x => x.Priklauso,
                        principalTable: "K_Darboviete",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "K_Darbuotojas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    Darboviete = table.Column<string>(type: "TEXT", nullable: false),
                    Asmuo = table.Column<int>(type: "INTEGER", nullable: true),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Pareigybe = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Tel1 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tel2 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tel3 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tel4 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_Darbuotojas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_K_Darbuotojas_K_Asmuo_Asmuo",
                        column: x => x.Asmuo,
                        principalTable: "K_Asmuo",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_K_Darbuotojas_K_Darboviete_Darboviete",
                        column: x => x.Darboviete,
                        principalTable: "K_Darboviete",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "I_AptarnavimoSutartis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AptarnaujantiImoneID = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    Iki = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Nuo = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_AptarnavimoSutartis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_AptarnavimoSutartis_I_AptarnaujantiImone_AptarnaujantiImoneID",
                        column: x => x.AptarnaujantiImoneID,
                        principalTable: "I_AptarnaujantiImone",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "I_Incidentas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    InformacinisIstekliusID = table.Column<string>(type: "TEXT", nullable: false),
                    PozymisID = table.Column<int>(type: "INTEGER", nullable: true),
                    Desc = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Reason = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Incidentas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_Incidentas_I_IncidentoPozymis_PozymisID",
                        column: x => x.PozymisID,
                        principalTable: "I_IncidentoPozymis",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_I_Incidentas_I_InformacinisIsteklius_InformacinisIstekliusID",
                        column: x => x.InformacinisIstekliusID,
                        principalTable: "I_InformacinisIsteklius",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "I_Kreipinys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AptarnaujantiImoneID = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    Krepinys = table.Column<string>(type: "TEXT", nullable: true),
                    Nuoroda = table.Column<string>(type: "TEXT", nullable: true),
                    IncidentasID = table.Column<int>(type: "INTEGER", nullable: true),
                    RequestText = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    SolutionText = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    Nuo = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Iki = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Kreipinys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_Kreipinys_I_AptarnaujantiImone_AptarnaujantiImoneID",
                        column: x => x.AptarnaujantiImoneID,
                        principalTable: "I_AptarnaujantiImone",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_Kreipinys_I_Incidentas_IncidentasID",
                        column: x => x.IncidentasID,
                        principalTable: "I_Incidentas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "I_Skundas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeID = table.Column<int>(type: "INTEGER", nullable: true),
                    DarbuotojasID = table.Column<int>(type: "INTEGER", nullable: true),
                    AsmuoID = table.Column<int>(type: "INTEGER", nullable: true),
                    Asmuo_FreeForm = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    At = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Markdown = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    IncidentasID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Skundas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_Skundas_I_Incidentas_IncidentasID",
                        column: x => x.IncidentasID,
                        principalTable: "I_Incidentas",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_I_Skundas_I_SkundasType_TypeID",
                        column: x => x.TypeID,
                        principalTable: "I_SkundasType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_I_Skundas_K_Asmuo_AsmuoID",
                        column: x => x.AsmuoID,
                        principalTable: "K_Asmuo",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_I_Skundas_K_Darbuotojas_DarbuotojasID",
                        column: x => x.DarbuotojasID,
                        principalTable: "K_Darbuotojas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "I_Sprendimas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KreipinysID = table.Column<int>(type: "INTEGER", nullable: false),
                    DarbuotojasID = table.Column<int>(type: "INTEGER", nullable: false),
                    SolutionMarkdown = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Sprendimas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_Sprendimas_I_Kreipinys_KreipinysID",
                        column: x => x.KreipinysID,
                        principalTable: "I_Kreipinys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_Sprendimas_K_Darbuotojas_DarbuotojasID",
                        column: x => x.DarbuotojasID,
                        principalTable: "K_Darbuotojas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_I_AptarnavimoSutartis_AptarnaujantiImoneID",
                table: "I_AptarnavimoSutartis",
                column: "AptarnaujantiImoneID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Incidentas_InformacinisIstekliusID",
                table: "I_Incidentas",
                column: "InformacinisIstekliusID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Incidentas_PozymisID",
                table: "I_Incidentas",
                column: "PozymisID");

            migrationBuilder.CreateIndex(
                name: "IX_I_InformacinisIsteklius_Parent",
                table: "I_InformacinisIsteklius",
                column: "Parent");

            migrationBuilder.CreateIndex(
                name: "IX_I_InformacinisIsteklius_Priklauso",
                table: "I_InformacinisIsteklius",
                column: "Priklauso");

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_AptarnaujantiImoneID",
                table: "I_Kreipinys",
                column: "AptarnaujantiImoneID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_IncidentasID",
                table: "I_Kreipinys",
                column: "IncidentasID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Skundas_AsmuoID",
                table: "I_Skundas",
                column: "AsmuoID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Skundas_DarbuotojasID",
                table: "I_Skundas",
                column: "DarbuotojasID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Skundas_IncidentasID",
                table: "I_Skundas",
                column: "IncidentasID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Skundas_TypeID",
                table: "I_Skundas",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Sprendimas_DarbuotojasID",
                table: "I_Sprendimas",
                column: "DarbuotojasID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Sprendimas_KreipinysID",
                table: "I_Sprendimas",
                column: "KreipinysID");

            migrationBuilder.CreateIndex(
                name: "IX_K_Darbuotojas_Asmuo",
                table: "K_Darbuotojas",
                column: "Asmuo");

            migrationBuilder.CreateIndex(
                name: "IX_K_Darbuotojas_Darboviete",
                table: "K_Darbuotojas",
                column: "Darboviete");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "I_AptarnavimoSutartis");

            migrationBuilder.DropTable(
                name: "I_Skundas");

            migrationBuilder.DropTable(
                name: "I_Sprendimas");

            migrationBuilder.DropTable(
                name: "I_SkundasType");

            migrationBuilder.DropTable(
                name: "I_Kreipinys");

            migrationBuilder.DropTable(
                name: "K_Darbuotojas");

            migrationBuilder.DropTable(
                name: "I_AptarnaujantiImone");

            migrationBuilder.DropTable(
                name: "I_Incidentas");

            migrationBuilder.DropTable(
                name: "K_Asmuo");

            migrationBuilder.DropTable(
                name: "I_IncidentoPozymis");

            migrationBuilder.DropTable(
                name: "I_InformacinisIsteklius");

            migrationBuilder.DropTable(
                name: "K_Darboviete");
        }
    }
}
