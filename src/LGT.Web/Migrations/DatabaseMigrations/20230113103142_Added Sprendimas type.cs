using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class AddedSprendimastype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DarbovieteIndex",
                table: "I_Kreipinys",
                newName: "ID");

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
                name: "IX_Sprenimas_KreipinysDarbovieteID_KreipinysID",
                table: "Sprenimas",
                columns: new[] { "KreipinysDarbovieteID", "KreipinysID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sprenimas");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "I_Kreipinys",
                newName: "DarbovieteIndex");
        }
    }
}
