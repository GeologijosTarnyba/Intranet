using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class AddedSprendimasDarbuotojasrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sprenimas");

            migrationBuilder.DropIndex(
                name: "IX_K_Darbuotojas_Darboviete",
                table: "K_Darbuotojas");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_K_Darbuotojas_Darboviete_ID",
                table: "K_Darbuotojas",
                columns: new[] { "Darboviete", "ID" });

            migrationBuilder.CreateTable(
                name: "Sprendimas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DarbovieteID = table.Column<string>(type: "TEXT", nullable: false),
                    KreipinysID = table.Column<int>(type: "INTEGER", nullable: false),
                    DarbuotojasID = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprendimas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sprendimas_I_Kreipinys_DarbovieteID_KreipinysID",
                        columns: x => new { x.DarbovieteID, x.KreipinysID },
                        principalTable: "I_Kreipinys",
                        principalColumns: new[] { "DarbovieteID", "ID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sprendimas_K_Darbuotojas_DarbovieteID_DarbuotojasID",
                        columns: x => new { x.DarbovieteID, x.DarbuotojasID },
                        principalTable: "K_Darbuotojas",
                        principalColumns: new[] { "Darboviete", "ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sprendimas_DarbovieteID_DarbuotojasID",
                table: "Sprendimas",
                columns: new[] { "DarbovieteID", "DarbuotojasID" });

            migrationBuilder.CreateIndex(
                name: "IX_Sprendimas_DarbovieteID_KreipinysID",
                table: "Sprendimas",
                columns: new[] { "DarbovieteID", "KreipinysID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sprendimas");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_K_Darbuotojas_Darboviete_ID",
                table: "K_Darbuotojas");

            migrationBuilder.CreateTable(
                name: "Sprenimas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KreipinysDarbovieteID = table.Column<string>(type: "TEXT", nullable: false),
                    KreipinysID = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprenimas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sprenimas_I_Kreipinys_KreipinysDarbovieteID_KreipinysID",
                        columns: x => new { x.KreipinysDarbovieteID, x.KreipinysID },
                        principalTable: "I_Kreipinys",
                        principalColumns: new[] { "DarbovieteID", "ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_K_Darbuotojas_Darboviete",
                table: "K_Darbuotojas",
                column: "Darboviete");

            migrationBuilder.CreateIndex(
                name: "IX_Sprenimas_KreipinysDarbovieteID_KreipinysID",
                table: "Sprenimas",
                columns: new[] { "KreipinysDarbovieteID", "KreipinysID" });
        }
    }
}
