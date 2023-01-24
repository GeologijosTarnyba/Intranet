using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class ChangedKrtepinysDarbovieterelationtoKreipinysAptarnaujantiImone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_I_Incidentas_IncidentasID",
                table: "I_Kreipinys");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_K_Darboviete_DarbovieteID",
                table: "I_Kreipinys");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Sprendimas_I_Kreipinys_DarbovieteID_KreipinysID",
                table: "I_Sprendimas");

            migrationBuilder.DropIndex(
                name: "IX_I_Sprendimas_DarbovieteID_KreipinysID",
                table: "I_Sprendimas");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_I_Kreipinys_DarbovieteID_ID",
                table: "I_Kreipinys");

            migrationBuilder.RenameColumn(
                name: "Until",
                table: "I_Kreipinys",
                newName: "Iki");

            migrationBuilder.RenameColumn(
                name: "Since",
                table: "I_Kreipinys",
                newName: "Nuo");

            migrationBuilder.AlterColumn<int>(
                name: "IncidentasID",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "DarbovieteID",
                table: "I_Kreipinys",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 32);

            migrationBuilder.AddColumn<string>(
                name: "AptarnaujantiImoneID",
                table: "I_Kreipinys",
                type: "TEXT",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "I_AptarnaujantiImone",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.CreateIndex(
                name: "IX_I_Sprendimas_KreipinysID",
                table: "I_Sprendimas",
                column: "KreipinysID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_AptarnaujantiImoneID",
                table: "I_Kreipinys",
                column: "AptarnaujantiImoneID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_DarbovieteID",
                table: "I_Kreipinys",
                column: "DarbovieteID");

            migrationBuilder.CreateIndex(
                name: "IX_I_AptarnavimoSutartis_AptarnaujantiImoneID",
                table: "I_AptarnavimoSutartis",
                column: "AptarnaujantiImoneID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_I_AptarnaujantiImone_AptarnaujantiImoneID",
                table: "I_Kreipinys",
                column: "AptarnaujantiImoneID",
                principalTable: "I_AptarnaujantiImone",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_I_Incidentas_IncidentasID",
                table: "I_Kreipinys",
                column: "IncidentasID",
                principalTable: "I_Incidentas",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_K_Darboviete_DarbovieteID",
                table: "I_Kreipinys",
                column: "DarbovieteID",
                principalTable: "K_Darboviete",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Sprendimas_I_Kreipinys_KreipinysID",
                table: "I_Sprendimas",
                column: "KreipinysID",
                principalTable: "I_Kreipinys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_I_AptarnaujantiImone_AptarnaujantiImoneID",
                table: "I_Kreipinys");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_I_Incidentas_IncidentasID",
                table: "I_Kreipinys");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_K_Darboviete_DarbovieteID",
                table: "I_Kreipinys");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Sprendimas_I_Kreipinys_KreipinysID",
                table: "I_Sprendimas");

            migrationBuilder.DropTable(
                name: "I_AptarnavimoSutartis");

            migrationBuilder.DropIndex(
                name: "IX_I_Sprendimas_KreipinysID",
                table: "I_Sprendimas");

            migrationBuilder.DropIndex(
                name: "IX_I_Kreipinys_AptarnaujantiImoneID",
                table: "I_Kreipinys");

            migrationBuilder.DropIndex(
                name: "IX_I_Kreipinys_DarbovieteID",
                table: "I_Kreipinys");

            migrationBuilder.DropColumn(
                name: "AptarnaujantiImoneID",
                table: "I_Kreipinys");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "I_AptarnaujantiImone");

            migrationBuilder.RenameColumn(
                name: "Nuo",
                table: "I_Kreipinys",
                newName: "Since");

            migrationBuilder.RenameColumn(
                name: "Iki",
                table: "I_Kreipinys",
                newName: "Until");

            migrationBuilder.AlterColumn<int>(
                name: "IncidentasID",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DarbovieteID",
                table: "I_Kreipinys",
                type: "TEXT",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_I_Kreipinys_DarbovieteID_ID",
                table: "I_Kreipinys",
                columns: new[] { "DarbovieteID", "ID" });

            migrationBuilder.CreateIndex(
                name: "IX_I_Sprendimas_DarbovieteID_KreipinysID",
                table: "I_Sprendimas",
                columns: new[] { "DarbovieteID", "KreipinysID" });

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_I_Incidentas_IncidentasID",
                table: "I_Kreipinys",
                column: "IncidentasID",
                principalTable: "I_Incidentas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_K_Darboviete_DarbovieteID",
                table: "I_Kreipinys",
                column: "DarbovieteID",
                principalTable: "K_Darboviete",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_I_Sprendimas_I_Kreipinys_DarbovieteID_KreipinysID",
                table: "I_Sprendimas",
                columns: new[] { "DarbovieteID", "KreipinysID" },
                principalTable: "I_Kreipinys",
                principalColumns: new[] { "DarbovieteID", "ID" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
