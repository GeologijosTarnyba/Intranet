using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class DarbuotojasappendedwithPareigubeTel1Tel2Tel3Tel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pareigybe",
                table: "K_Darbuotojas",
                type: "TEXT",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel1",
                table: "K_Darbuotojas",
                type: "TEXT",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel2",
                table: "K_Darbuotojas",
                type: "TEXT",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel3",
                table: "K_Darbuotojas",
                type: "TEXT",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel4",
                table: "K_Darbuotojas",
                type: "TEXT",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pareigybe",
                table: "K_Darbuotojas");

            migrationBuilder.DropColumn(
                name: "Tel1",
                table: "K_Darbuotojas");

            migrationBuilder.DropColumn(
                name: "Tel2",
                table: "K_Darbuotojas");

            migrationBuilder.DropColumn(
                name: "Tel3",
                table: "K_Darbuotojas");

            migrationBuilder.DropColumn(
                name: "Tel4",
                table: "K_Darbuotojas");
        }
    }
}
