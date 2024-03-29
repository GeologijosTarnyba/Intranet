using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Intranet.Migrations.KontaktaiContextMigrations
{
    /// <inheritdoc />
    public partial class Initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Darbovietes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    OrderWeight = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Darbovietes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EtatuPavadinimai",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: true),
                    Vardininkas = table.Column<string>(type: "TEXT", nullable: true),
                    Vardininke = table.Column<string>(type: "TEXT", nullable: true),
                    Kilmininkas = table.Column<string>(type: "TEXT", nullable: true),
                    Kilmininke = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtatuPavadinimai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Padaliniai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DarbovieteId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false),
                    NameShort = table.Column<string>(type: "TEXT", maxLength: 16, nullable: true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padaliniai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Padaliniai_Darbovietes_DarbovieteId",
                        column: x => x.DarbovieteId,
                        principalTable: "Darbovietes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Etatai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    NameId = table.Column<string>(type: "TEXT", nullable: false),
                    DarbovieteId = table.Column<string>(type: "TEXT", nullable: false),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PadalinysId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etatai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etatai_Darbovietes_DarbovieteId",
                        column: x => x.DarbovieteId,
                        principalTable: "Darbovietes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Etatai_EtatuPavadinimai_NameId",
                        column: x => x.NameId,
                        principalTable: "EtatuPavadinimai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Etatai_Padaliniai_PadalinysId",
                        column: x => x.PadalinysId,
                        principalTable: "Padaliniai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Darbuotojai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Darboviete = table.Column<string>(type: "TEXT", nullable: false),
                    PadalinysId = table.Column<Guid>(type: "TEXT", nullable: true),
                    EtatasId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Lytis = table.Column<int>(type: "INTEGER", nullable: true),
                    Since = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Until = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Pareigybe = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Kabinetas = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tel1 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tel2 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tel3 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tel4 = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Darbuotojai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Darbuotojai_Darbovietes_Darboviete",
                        column: x => x.Darboviete,
                        principalTable: "Darbovietes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Darbuotojai_Etatai_EtatasId",
                        column: x => x.EtatasId,
                        principalTable: "Etatai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Darbuotojai_Padaliniai_PadalinysId",
                        column: x => x.PadalinysId,
                        principalTable: "Padaliniai",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Darbuotojai_Darboviete",
                table: "Darbuotojai",
                column: "Darboviete");

            migrationBuilder.CreateIndex(
                name: "IX_Darbuotojai_EtatasId",
                table: "Darbuotojai",
                column: "EtatasId");

            migrationBuilder.CreateIndex(
                name: "IX_Darbuotojai_PadalinysId",
                table: "Darbuotojai",
                column: "PadalinysId");

            migrationBuilder.CreateIndex(
                name: "IX_Etatai_DarbovieteId",
                table: "Etatai",
                column: "DarbovieteId");

            migrationBuilder.CreateIndex(
                name: "IX_Etatai_NameId",
                table: "Etatai",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Etatai_PadalinysId",
                table: "Etatai",
                column: "PadalinysId");

            migrationBuilder.CreateIndex(
                name: "IX_Padaliniai_DarbovieteId",
                table: "Padaliniai",
                column: "DarbovieteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Darbuotojai");

            migrationBuilder.DropTable(
                name: "Etatai");

            migrationBuilder.DropTable(
                name: "EtatuPavadinimai");

            migrationBuilder.DropTable(
                name: "Padaliniai");

            migrationBuilder.DropTable(
                name: "Darbovietes");
        }
    }
}
