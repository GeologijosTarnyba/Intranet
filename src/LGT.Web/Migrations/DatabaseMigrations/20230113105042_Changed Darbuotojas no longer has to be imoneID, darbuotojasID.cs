using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class ChangedDarbuotojasnolongerhastobeimoneIDdarbuotojasID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_K_Darbuotojas_K_Asmuo_Asmuo",
                table: "K_Darbuotojas");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_K_Darbuotojas_Asmuo_Darboviete",
                table: "K_Darbuotojas");

            migrationBuilder.AlterColumn<int>(
                name: "Asmuo",
                table: "K_Darbuotojas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_K_Darbuotojas_Asmuo",
                table: "K_Darbuotojas",
                column: "Asmuo");

            migrationBuilder.AddForeignKey(
                name: "FK_K_Darbuotojas_K_Asmuo_Asmuo",
                table: "K_Darbuotojas",
                column: "Asmuo",
                principalTable: "K_Asmuo",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_K_Darbuotojas_K_Asmuo_Asmuo",
                table: "K_Darbuotojas");

            migrationBuilder.DropIndex(
                name: "IX_K_Darbuotojas_Asmuo",
                table: "K_Darbuotojas");

            migrationBuilder.AlterColumn<int>(
                name: "Asmuo",
                table: "K_Darbuotojas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_K_Darbuotojas_Asmuo_Darboviete",
                table: "K_Darbuotojas",
                columns: new[] { "Asmuo", "Darboviete" });

            migrationBuilder.AddForeignKey(
                name: "FK_K_Darbuotojas_K_Asmuo_Asmuo",
                table: "K_Darbuotojas",
                column: "Asmuo",
                principalTable: "K_Asmuo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
