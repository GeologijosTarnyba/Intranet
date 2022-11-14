using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations
{
    public partial class removedCountcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColumnsCount",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "LinksCount",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupsCount",
                table: "Columns");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColumnsCount",
                table: "Pages",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LinksCount",
                table: "Groups",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupsCount",
                table: "Columns",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);
        }
    }
}
