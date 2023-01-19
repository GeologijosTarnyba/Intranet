using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class InformacinisIstekliusmustbelongtoDarboviete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_InformacinisIsteklius_K_Darboviete_Darboviete",
                table: "I_InformacinisIsteklius");

            migrationBuilder.RenameColumn(
                name: "Darboviete",
                table: "I_InformacinisIsteklius",
                newName: "Priklauso");

            migrationBuilder.RenameIndex(
                name: "IX_I_InformacinisIsteklius_Darboviete",
                table: "I_InformacinisIsteklius",
                newName: "IX_I_InformacinisIsteklius_Priklauso");

            migrationBuilder.AlterColumn<string>(
                name: "Priklauso",
                table: "I_InformacinisIsteklius",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_I_InformacinisIsteklius_K_Darboviete_Priklauso",
                table: "I_InformacinisIsteklius",
                column: "Priklauso",
                principalTable: "K_Darboviete",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_InformacinisIsteklius_K_Darboviete_Priklauso",
                table: "I_InformacinisIsteklius");

            migrationBuilder.RenameColumn(
                name: "Priklauso",
                table: "I_InformacinisIsteklius",
                newName: "Darboviete");

            migrationBuilder.RenameIndex(
                name: "IX_I_InformacinisIsteklius_Priklauso",
                table: "I_InformacinisIsteklius",
                newName: "IX_I_InformacinisIsteklius_Darboviete");

            migrationBuilder.AlterColumn<string>(
                name: "Darboviete",
                table: "I_InformacinisIsteklius",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_I_InformacinisIsteklius_K_Darboviete_Darboviete",
                table: "I_InformacinisIsteklius",
                column: "Darboviete",
                principalTable: "K_Darboviete",
                principalColumn: "ID");
        }
    }
}
