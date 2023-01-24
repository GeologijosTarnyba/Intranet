using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class AddedIncidentasRequestText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Markdown",
                table: "I_Skundas",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "I_Kreipinys",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "datetime()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValueSql: "datetime()");

            migrationBuilder.AddColumn<string>(
                name: "RequestText",
                table: "I_Kreipinys",
                type: "TEXT",
                maxLength: 1000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestText",
                table: "I_Kreipinys");

            migrationBuilder.AlterColumn<string>(
                name: "Markdown",
                table: "I_Skundas",
                type: "TEXT",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "I_Kreipinys",
                type: "TEXT",
                nullable: true,
                defaultValueSql: "datetime()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "datetime()");
        }
    }
}
