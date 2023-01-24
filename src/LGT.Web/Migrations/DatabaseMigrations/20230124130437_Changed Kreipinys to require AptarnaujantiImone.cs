using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class ChangedKreipinystorequireAptarnaujantiImone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_I_AptarnaujantiImone_AptarnaujantiImoneID",
                table: "I_Kreipinys");

            migrationBuilder.AlterColumn<string>(
                name: "AptarnaujantiImoneID",
                table: "I_Kreipinys",
                type: "TEXT",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_I_AptarnaujantiImone_AptarnaujantiImoneID",
                table: "I_Kreipinys",
                column: "AptarnaujantiImoneID",
                principalTable: "I_AptarnaujantiImone",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_Kreipinys_I_AptarnaujantiImone_AptarnaujantiImoneID",
                table: "I_Kreipinys");

            migrationBuilder.AlterColumn<string>(
                name: "AptarnaujantiImoneID",
                table: "I_Kreipinys",
                type: "TEXT",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 32);

            migrationBuilder.AddForeignKey(
                name: "FK_I_Kreipinys_I_AptarnaujantiImone_AptarnaujantiImoneID",
                table: "I_Kreipinys",
                column: "AptarnaujantiImoneID",
                principalTable: "I_AptarnaujantiImone",
                principalColumn: "ID");
        }
    }
}
