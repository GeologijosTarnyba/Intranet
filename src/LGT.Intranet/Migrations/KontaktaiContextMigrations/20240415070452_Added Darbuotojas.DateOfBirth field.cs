using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Intranet.Migrations.KontaktaiContextMigrations
{
    /// <inheritdoc />
    public partial class AddedDarbuotojasDateOfBirthfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "Darbuotojai",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Darbuotojai");
        }
    }
}
