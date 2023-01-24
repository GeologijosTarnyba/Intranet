using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class RemovedSprendimasDarbovietefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Sprendimas_K_Darbuotojas_DarbovieteID_DarbuotojasID",
                table: "I_Sprendimas");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_K_Darbuotojas_Darboviete_ID",
                table: "K_Darbuotojas");

            migrationBuilder.DropIndex(
                name: "IX_I_Sprendimas_DarbovieteID_DarbuotojasID",
                table: "I_Sprendimas");

            migrationBuilder.DropColumn(
                name: "DarbovieteID",
                table: "I_Sprendimas");

            migrationBuilder.CreateIndex(
                name: "IX_K_Darbuotojas_Darboviete",
                table: "K_Darbuotojas",
                column: "Darboviete");

            migrationBuilder.CreateIndex(
                name: "IX_I_Sprendimas_DarbuotojasID",
                table: "I_Sprendimas",
                column: "DarbuotojasID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Sprendimas_K_Darbuotojas_DarbuotojasID",
                table: "I_Sprendimas",
                column: "DarbuotojasID",
                principalTable: "K_Darbuotojas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Sprendimas_K_Darbuotojas_DarbuotojasID",
                table: "I_Sprendimas");

            migrationBuilder.DropIndex(
                name: "IX_K_Darbuotojas_Darboviete",
                table: "K_Darbuotojas");

            migrationBuilder.DropIndex(
                name: "IX_I_Sprendimas_DarbuotojasID",
                table: "I_Sprendimas");

            migrationBuilder.AddColumn<string>(
                name: "DarbovieteID",
                table: "I_Sprendimas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_K_Darbuotojas_Darboviete_ID",
                table: "K_Darbuotojas",
                columns: new[] { "Darboviete", "ID" });

            migrationBuilder.CreateIndex(
                name: "IX_I_Sprendimas_DarbovieteID_DarbuotojasID",
                table: "I_Sprendimas",
                columns: new[] { "DarbovieteID", "DarbuotojasID" });

            migrationBuilder.AddForeignKey(
                name: "FK_I_Sprendimas_K_Darbuotojas_DarbovieteID_DarbuotojasID",
                table: "I_Sprendimas",
                columns: new[] { "DarbovieteID", "DarbuotojasID" },
                principalTable: "K_Darbuotojas",
                principalColumns: new[] { "Darboviete", "ID" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
