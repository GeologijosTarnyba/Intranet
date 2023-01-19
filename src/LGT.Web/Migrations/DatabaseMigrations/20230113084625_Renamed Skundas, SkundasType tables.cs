using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class RenamedSkundasSkundasTypetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_I_Incidentas_IncidentasID",
                table: "Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_K_Asmuo_AsmuoID",
                table: "Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_K_Darbuotojas_DarbuotojasID",
                table: "Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_SkundasType_TypeID",
                table: "Skundas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkundasType",
                table: "SkundasType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skundas",
                table: "Skundas");

            migrationBuilder.RenameTable(
                name: "SkundasType",
                newName: "I_SkundasType");

            migrationBuilder.RenameTable(
                name: "Skundas",
                newName: "I_Skundas");

            migrationBuilder.RenameIndex(
                name: "IX_Skundas_TypeID",
                table: "I_Skundas",
                newName: "IX_I_Skundas_TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Skundas_IncidentasID",
                table: "I_Skundas",
                newName: "IX_I_Skundas_IncidentasID");

            migrationBuilder.RenameIndex(
                name: "IX_Skundas_DarbuotojasID",
                table: "I_Skundas",
                newName: "IX_I_Skundas_DarbuotojasID");

            migrationBuilder.RenameIndex(
                name: "IX_Skundas_AsmuoID",
                table: "I_Skundas",
                newName: "IX_I_Skundas_AsmuoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_I_SkundasType",
                table: "I_SkundasType",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_I_Skundas",
                table: "I_Skundas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Skundas_I_Incidentas_IncidentasID",
                table: "I_Skundas",
                column: "IncidentasID",
                principalTable: "I_Incidentas",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Skundas_I_SkundasType_TypeID",
                table: "I_Skundas",
                column: "TypeID",
                principalTable: "I_SkundasType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Skundas_K_Asmuo_AsmuoID",
                table: "I_Skundas",
                column: "AsmuoID",
                principalTable: "K_Asmuo",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Skundas_K_Darbuotojas_DarbuotojasID",
                table: "I_Skundas",
                column: "DarbuotojasID",
                principalTable: "K_Darbuotojas",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Skundas_I_Incidentas_IncidentasID",
                table: "I_Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Skundas_I_SkundasType_TypeID",
                table: "I_Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Skundas_K_Asmuo_AsmuoID",
                table: "I_Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Skundas_K_Darbuotojas_DarbuotojasID",
                table: "I_Skundas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_I_SkundasType",
                table: "I_SkundasType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_I_Skundas",
                table: "I_Skundas");

            migrationBuilder.RenameTable(
                name: "I_SkundasType",
                newName: "SkundasType");

            migrationBuilder.RenameTable(
                name: "I_Skundas",
                newName: "Skundas");

            migrationBuilder.RenameIndex(
                name: "IX_I_Skundas_TypeID",
                table: "Skundas",
                newName: "IX_Skundas_TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_I_Skundas_IncidentasID",
                table: "Skundas",
                newName: "IX_Skundas_IncidentasID");

            migrationBuilder.RenameIndex(
                name: "IX_I_Skundas_DarbuotojasID",
                table: "Skundas",
                newName: "IX_Skundas_DarbuotojasID");

            migrationBuilder.RenameIndex(
                name: "IX_I_Skundas_AsmuoID",
                table: "Skundas",
                newName: "IX_Skundas_AsmuoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkundasType",
                table: "SkundasType",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skundas",
                table: "Skundas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_I_Incidentas_IncidentasID",
                table: "Skundas",
                column: "IncidentasID",
                principalTable: "I_Incidentas",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_K_Asmuo_AsmuoID",
                table: "Skundas",
                column: "AsmuoID",
                principalTable: "K_Asmuo",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_K_Darbuotojas_DarbuotojasID",
                table: "Skundas",
                column: "DarbuotojasID",
                principalTable: "K_Darbuotojas",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_SkundasType_TypeID",
                table: "Skundas",
                column: "TypeID",
                principalTable: "SkundasType",
                principalColumn: "ID");
        }
    }
}
