using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class AddedSkundastype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skundas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DarbovieteID = table.Column<string>(type: "TEXT", nullable: true),
                    AsmuoID = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Markdown = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    IncidentasID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skundas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skundas_I_Incidentas_IncidentasID",
                        column: x => x.IncidentasID,
                        principalTable: "I_Incidentas",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Skundas_K_Asmuo_AsmuoID",
                        column: x => x.AsmuoID,
                        principalTable: "K_Asmuo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Skundas_K_Darboviete_DarbovieteID",
                        column: x => x.DarbovieteID,
                        principalTable: "K_Darboviete",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Skundas_K_Darbuotojas_DarbovieteID_AsmuoID",
                        columns: x => new { x.DarbovieteID, x.AsmuoID },
                        principalTable: "K_Darbuotojas",
                        principalColumns: new[] { "Darboviete", "Asmuo" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skundas_AsmuoID",
                table: "Skundas",
                column: "AsmuoID");

            migrationBuilder.CreateIndex(
                name: "IX_Skundas_DarbovieteID_AsmuoID",
                table: "Skundas",
                columns: new[] { "DarbovieteID", "AsmuoID" });

            migrationBuilder.CreateIndex(
                name: "IX_Skundas_IncidentasID",
                table: "Skundas",
                column: "IncidentasID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skundas");
        }
    }
}
