using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class Addedtypeskundastype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Skundas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SkundasType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkundasType", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skundas_TypeID",
                table: "Skundas",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skundas_SkundasType_TypeID",
                table: "Skundas",
                column: "TypeID",
                principalTable: "SkundasType",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skundas_SkundasType_TypeID",
                table: "Skundas");

            migrationBuilder.DropTable(
                name: "SkundasType");

            migrationBuilder.DropIndex(
                name: "IX_Skundas_TypeID",
                table: "Skundas");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Skundas");
        }
    }
}
