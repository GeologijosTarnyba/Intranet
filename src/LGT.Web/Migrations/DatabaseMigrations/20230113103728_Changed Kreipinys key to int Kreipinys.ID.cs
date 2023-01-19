using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class ChangedKreipinyskeytointKreipinysID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_I_Kreipinys_DarbovieteID_ID",
                table: "I_Kreipinys",
                columns: new[] { "DarbovieteID", "ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_I_Kreipinys_DarbovieteID_ID",
                table: "I_Kreipinys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "I_Kreipinys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_I_Kreipinys",
                table: "I_Kreipinys",
                columns: new[] { "DarbovieteID", "ID" });
        }
    }
}
