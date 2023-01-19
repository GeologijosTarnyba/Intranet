using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class Changedkreipinyskey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_K_Asmuo_AsmuoID",
                table: "I_Kreipinys");

            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_K_Darbuotojas_DarbovieteID_AsmuoID",
                table: "I_Kreipinys");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_K_Darbuotojas_Darboviete_Asmuo",
                table: "K_Darbuotojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys");

            migrationBuilder.DropIndex(
                name: "IX_I_Kreipinys_AsmuoID",
                table: "I_Kreipinys");

            migrationBuilder.DropIndex(
                name: "IX_I_Kreipinys_DarbovieteID_AsmuoID",
                table: "I_Kreipinys");

            migrationBuilder.DropColumn(
                name: "AsmuoID",
                table: "I_Kreipinys");

            migrationBuilder.DropColumn(
                name: "DarbuotojasID",
                table: "I_Kreipinys");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "I_Kreipinys",
                newName: "DarbovieteIndex");

            migrationBuilder.AddColumn<int>(
                name: "Index",
                table: "K_Darbuotojas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DarbovieteIndex",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys",
                columns: new[] { "DarbovieteID", "DarbovieteIndex" });

            migrationBuilder.CreateIndex(
                name: "IX_K_Darbuotojas_Darboviete",
                table: "K_Darbuotojas",
                column: "Darboviete");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_K_Darbuotojas_Darboviete",
                table: "K_Darbuotojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys");

            migrationBuilder.DropColumn(
                name: "Index",
                table: "K_Darbuotojas");

            migrationBuilder.RenameColumn(
                name: "DarbovieteIndex",
                table: "I_Kreipinys",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "AsmuoID",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DarbuotojasID",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_K_Darbuotojas_Darboviete_Asmuo",
                table: "K_Darbuotojas",
                columns: new[] { "Darboviete", "Asmuo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_AsmuoID",
                table: "I_Kreipinys",
                column: "AsmuoID");

            migrationBuilder.CreateIndex(
                name: "IX_I_Kreipinys_DarbovieteID_AsmuoID",
                table: "I_Kreipinys",
                columns: new[] { "DarbovieteID", "AsmuoID" });

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_K_Asmuo_AsmuoID",
                table: "I_Kreipinys",
                column: "AsmuoID",
                principalTable: "K_Asmuo",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_K_Darbuotojas_DarbovieteID_AsmuoID",
                table: "I_Kreipinys",
                columns: new[] { "DarbovieteID", "AsmuoID" },
                principalTable: "K_Darbuotojas",
                principalColumns: new[] { "Darboviete", "Asmuo" });
        }
    }
}
