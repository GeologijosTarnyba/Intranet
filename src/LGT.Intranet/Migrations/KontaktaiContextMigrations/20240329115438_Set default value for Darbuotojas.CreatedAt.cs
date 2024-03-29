using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Intranet.Migrations.KontaktaiContextMigrations
{
    /// <inheritdoc />
    public partial class SetdefaultvalueforDarbuotojasCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Darbuotojai",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "datetime()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Darbuotojai",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "datetime()");
        }
    }
}
