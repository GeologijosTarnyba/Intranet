using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class InformacinisIstekliusgalipriklausytiDarbovietei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Darboviete",
                table: "I_InformacinisIsteklius",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_I_InformacinisIsteklius_Darboviete",
                table: "I_InformacinisIsteklius",
                column: "Darboviete");

            migrationBuilder.AddForeignKey(
                name: "FK_I_InformacinisIsteklius_K_Darboviete_Darboviete",
                table: "I_InformacinisIsteklius",
                column: "Darboviete",
                principalTable: "K_Darboviete",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_InformacinisIsteklius_K_Darboviete_Darboviete",
                table: "I_InformacinisIsteklius");

            migrationBuilder.DropIndex(
                name: "IX_I_InformacinisIsteklius_Darboviete",
                table: "I_InformacinisIsteklius");

            migrationBuilder.DropColumn(
                name: "Darboviete",
                table: "I_InformacinisIsteklius");
        }
    }
}
