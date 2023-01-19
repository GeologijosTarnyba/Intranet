using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class RemovedSkundasDarbovieterelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_K_Asmuo_AsmuoID",
                table: "Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_K_Darboviete_DarbovieteID",
                table: "Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_K_Darbuotojas_DarbovieteID_AsmuoID",
                table: "Skundas");

            migrationBuilder.DropIndex(
                name: "IX_Skundas_DarbovieteID_AsmuoID",
                table: "Skundas");

            migrationBuilder.DropColumn(
                name: "DarbovieteID",
                table: "Skundas");

            migrationBuilder.AlterColumn<int>(
                name: "AsmuoID",
                table: "Skundas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Skundas_DarbuotojasID",
                table: "Skundas",
                column: "DarbuotojasID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_K_Asmuo_AsmuoID",
                table: "Skundas");

            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_K_Darbuotojas_DarbuotojasID",
                table: "Skundas");

            migrationBuilder.DropIndex(
                name: "IX_Skundas_DarbuotojasID",
                table: "Skundas");

            migrationBuilder.AlterColumn<int>(
                name: "AsmuoID",
                table: "Skundas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DarbovieteID",
                table: "Skundas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skundas_DarbovieteID_AsmuoID",
                table: "Skundas",
                columns: new[] { "DarbovieteID", "AsmuoID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_K_Asmuo_AsmuoID",
                table: "Skundas",
                column: "AsmuoID",
                principalTable: "K_Asmuo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_K_Darboviete_DarbovieteID",
                table: "Skundas",
                column: "DarbovieteID",
                principalTable: "K_Darboviete",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_K_Darbuotojas_DarbovieteID_AsmuoID",
                table: "Skundas",
                columns: new[] { "DarbovieteID", "AsmuoID" },
                principalTable: "K_Darbuotojas",
                principalColumns: new[] { "Darboviete", "Asmuo" });
        }
    }
}
