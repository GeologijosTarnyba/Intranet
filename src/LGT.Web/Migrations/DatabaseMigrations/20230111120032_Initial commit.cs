using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class Initialcommit : Migration
    {
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
                name: "I_InformacinisIsteklius",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Parent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_InformacinisIsteklius", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_InformacinisIsteklius_I_InformacinisIsteklius_Parent",
                        column: x => x.Parent,
                        principalTable: "I_InformacinisIsteklius",
                        principalColumn: "ID");
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
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_Darboviete", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "I_Incidentas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InformacinisIstekliusID = table.Column<string>(type: "TEXT", nullable: false),
                    PozymisID = table.Column<int>(type: "INTEGER", nullable: true),
                    Desc = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Reason = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true)
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
                name: "I_AptarnaujantiImone",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false)
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
                name: "K_Darbuotojas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Darboviete = table.Column<string>(type: "TEXT", nullable: false),
                    Asmuo = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_Darbuotojas", x => x.ID);
                    table.UniqueConstraint("AK_K_Darbuotojas_Asmuo_Darboviete", x => new { x.Asmuo, x.Darboviete });
                    table.UniqueConstraint("AK_K_Darbuotojas_Darboviete_Asmuo", x => new { x.Darboviete, x.Asmuo });
                    table.ForeignKey(
                        name: "FK_K_Darbuotojas_K_Asmuo_Asmuo",
                        column: x => x.Asmuo,
                        principalTable: "K_Asmuo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_K_Darbuotojas_K_Darboviete_Darboviete",
                        column: x => x.Darboviete,
                        principalTable: "K_Darboviete",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "I_Kreipinys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValueSql: "datetime()"),
                    DarbovieteID = table.Column<string>(type: "TEXT", nullable: false),
                    AsmuoID = table.Column<int>(type: "INTEGER", nullable: true),
                    Krepinys = table.Column<string>(type: "TEXT", nullable: true),
                    Nuoroda = table.Column<string>(type: "TEXT", nullable: true),
                    IncidentasID = table.Column<int>(type: "INTEGER", nullable: false),
                    SolutionText = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Kreipinys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I_Kreipinys_I_Incidentas_IncidentasID",
                        column: x => x.IncidentasID,
                        principalTable: "I_Incidentas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_Kreipinys_K_Asmuo_AsmuoID",
                        column: x => x.AsmuoID,
                        principalTable: "K_Asmuo",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_I_Kreipinys_K_Darboviete_DarbovieteID",
                        column: x => x.DarbovieteID,
                        principalTable: "K_Darboviete",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_Kreipinys_K_Darbuotojas_DarbovieteID_AsmuoID",
                        columns: x => new { x.DarbovieteID, x.AsmuoID },
                        principalTable: "K_Darbuotojas",
                        principalColumns: new[] { "Darboviete", "Asmuo" });
                });

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
                name: "IX_I_Kreipinys_AsmuoID",
                table: "I_Kreipinys",
                column: "AsmuoID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_DarbovieteID_AsmuoID",
                table: "I_Kreipinys",
                columns: new[] { "DarbovieteID", "AsmuoID" });

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_IncidentasID",
                table: "I_Kreipinys",
                column: "IncidentasID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "I_AptarnaujantiImone");

            migrationBuilder.DropTable(
                name: "I_Kreipinys");

            migrationBuilder.DropTable(
                name: "I_Incidentas");

            migrationBuilder.DropTable(
                name: "K_Darbuotojas");

            migrationBuilder.DropTable(
                name: "I_IncidentoPozymis");

            migrationBuilder.DropTable(
                name: "I_InformacinisIsteklius");

            migrationBuilder.DropTable(
                name: "K_Asmuo");

            migrationBuilder.DropTable(
                name: "K_Darboviete");
        }
    }
}
