using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class RemovedDarbovieteKreipinysrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_K_Darboviete_DarbovieteID",
                table: "I_Kreipinys");

            migrationBuilder.DropIndex(
                name: "IX_I_Kreipinys_DarbovieteID",
                table: "I_Kreipinys");

            migrationBuilder.DropColumn(
                name: "DarbovieteID",
                table: "I_Kreipinys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DarbovieteID",
                table: "I_Kreipinys",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_DarbovieteID",
                table: "I_Kreipinys",
                column: "DarbovieteID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_K_Darboviete_DarbovieteID",
                table: "I_Kreipinys",
                column: "DarbovieteID",
                principalTable: "K_Darboviete",
                principalColumn: "ID");
        }
    }
}
