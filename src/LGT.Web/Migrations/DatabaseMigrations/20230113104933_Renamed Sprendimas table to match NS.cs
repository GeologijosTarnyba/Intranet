using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class RenamedSprendimastabletomatchNS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sprendimas_I_Kreipinys_DarbovieteID_KreipinysID",
                table: "Sprendimas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprendimas_K_Darbuotojas_DarbovieteID_DarbuotojasID",
                table: "Sprendimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sprendimas",
                table: "Sprendimas");

            migrationBuilder.RenameTable(
                name: "Sprendimas",
                newName: "I_Sprendimas");

            migrationBuilder.RenameIndex(
                name: "IX_Sprendimas_DarbovieteID_KreipinysID",
                table: "I_Sprendimas",
                newName: "IX_I_Sprendimas_DarbovieteID_KreipinysID");

            migrationBuilder.RenameIndex(
                name: "IX_Sprendimas_DarbovieteID_DarbuotojasID",
                table: "I_Sprendimas",
                newName: "IX_I_Sprendimas_DarbovieteID_DarbuotojasID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_I_Sprendimas",
                table: "I_Sprendimas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Sprendimas_I_Kreipinys_DarbovieteID_KreipinysID",
                table: "I_Sprendimas",
                columns: new[] { "DarbovieteID", "KreipinysID" },
                principalTable: "I_Kreipinys",
                principalColumns: new[] { "DarbovieteID", "ID" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_I_Sprendimas_K_Darbuotojas_DarbovieteID_DarbuotojasID",
                table: "I_Sprendimas",
                columns: new[] { "DarbovieteID", "DarbuotojasID" },
                principalTable: "K_Darbuotojas",
                principalColumns: new[] { "Darboviete", "ID" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Sprendimas_I_Kreipinys_DarbovieteID_KreipinysID",
                table: "I_Sprendimas");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Sprendimas_K_Darbuotojas_DarbovieteID_DarbuotojasID",
                table: "I_Sprendimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_I_Sprendimas",
                table: "I_Sprendimas");

            migrationBuilder.RenameTable(
                name: "I_Sprendimas",
                newName: "Sprendimas");

            migrationBuilder.RenameIndex(
                name: "IX_I_Sprendimas_DarbovieteID_KreipinysID",
                table: "Sprendimas",
                newName: "IX_Sprendimas_DarbovieteID_KreipinysID");

            migrationBuilder.RenameIndex(
                name: "IX_I_Sprendimas_DarbovieteID_DarbuotojasID",
                table: "Sprendimas",
                newName: "IX_Sprendimas_DarbovieteID_DarbuotojasID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sprendimas",
                table: "Sprendimas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sprendimas_I_Kreipinys_DarbovieteID_KreipinysID",
                table: "Sprendimas",
                columns: new[] { "DarbovieteID", "KreipinysID" },
                principalTable: "I_Kreipinys",
                principalColumns: new[] { "DarbovieteID", "ID" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprendimas_K_Darbuotojas_DarbovieteID_DarbuotojasID",
                table: "Sprendimas",
                columns: new[] { "DarbovieteID", "DarbuotojasID" },
                principalTable: "K_Darbuotojas",
                principalColumns: new[] { "Darboviete", "ID" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
