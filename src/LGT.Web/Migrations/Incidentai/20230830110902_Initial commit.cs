using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    public partial class Initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INC_GRUPES",
                columns: table => new
                {
                    GR_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    GR_GR_ID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    GR_INDEX = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    GR_PAV = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: false),
                    GR_APRASYMAS = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INC_GRUPES", x => x.GR_ID);
                    table.ForeignKey(
                        name: "FK_INC_GRUPES_INC_GRUPES_GR_G~",
                        column: x => x.GR_GR_ID,
                        principalTable: "INC_GRUPES",
                        principalColumn: "GR_ID");
                });

            migrationBuilder.CreateTable(
                name: "INC_POVEIKIAI",
                columns: table => new
                {
                    POV_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 25, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    POV_PAV = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    POV_YRATIKRAS = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INC_POVEIKIAI", x => x.POV_ID);
                });

            migrationBuilder.CreateTable(
                name: "INC_RIZIKOS",
                columns: table => new
                {
                    RIZ_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 25, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RIZ_PAV = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INC_RIZIKOS", x => x.RIZ_ID);
                });

            migrationBuilder.CreateTable(
                name: "INF_IST_TIPAI",
                columns: table => new
                {
                    TIP_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 25, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TIP_INDEX = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TIP_PAV = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INF_IST_TIPAI", x => x.TIP_ID);
                });

            migrationBuilder.CreateTable(
                name: "KR_APTARNAUJANTYS",
                columns: table => new
                {
                    APT_TRUMP = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    APT_PAV = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KR_APTARNAUJANTYS", x => x.APT_TRUMP);
                });

            migrationBuilder.CreateTable(
                name: "INCIDENTAI",
                columns: table => new
                {
                    INC_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    INC_APRASYMAS = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: false),
                    INC_DATA_NUO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    INC_DATA_PASTEBETAS = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    INC_DATA_IKI = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    INC_RIZ_ID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    INC_POV_ID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INCIDENTAI", x => x.INC_ID);
                    table.ForeignKey(
                        name: "FK_INCIDENTAI_INC_POVEIKIAI_I~",
                        column: x => x.INC_POV_ID,
                        principalTable: "INC_POVEIKIAI",
                        principalColumn: "POV_ID");
                    table.ForeignKey(
                        name: "FK_INCIDENTAI_INC_RIZIKOS_INC~",
                        column: x => x.INC_RIZ_ID,
                        principalTable: "INC_RIZIKOS",
                        principalColumn: "RIZ_ID");
                });

            migrationBuilder.CreateTable(
                name: "INFORMACINIAI_ISTEKLIAI",
                columns: table => new
                {
                    IST_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    IST_TIP_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 25, nullable: false),
                    IST_INDEX = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    IST_PAV = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: false),
                    IST_RTO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INFORMACINIAI_ISTEKLIAI", x => x.IST_ID);
                    table.ForeignKey(
                        name: "FK_INFORMACINIAI_ISTEKLIAI_IN~",
                        column: x => x.IST_TIP_ID,
                        principalTable: "INF_IST_TIPAI",
                        principalColumn: "TIP_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INCIDENTU_GRUPES",
                columns: table => new
                {
                    R_INC_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    R_GR_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INCIDENTU_GRUPES", x => new { x.R_GR_ID, x.R_INC_ID });
                    table.ForeignKey(
                        name: "FK_INCIDENTU_GRUPES_INC_GRUPE~",
                        column: x => x.R_GR_ID,
                        principalTable: "INC_GRUPES",
                        principalColumn: "GR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INCIDENTU_GRUPES_INCIDENTA~",
                        column: x => x.R_INC_ID,
                        principalTable: "INCIDENTAI",
                        principalColumn: "INC_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KREIPINIAI",
                columns: table => new
                {
                    KR_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KR_APT_TRUMP = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    KR_NR = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    KR_INC_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KREIPINIAI", x => x.KR_ID);
                    table.ForeignKey(
                        name: "FK_KREIPINIAI_INCIDENTAI_KR_I~",
                        column: x => x.KR_INC_ID,
                        principalTable: "INCIDENTAI",
                        principalColumn: "INC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KREIPINIAI_KR_APTARNAUJANT~",
                        column: x => x.KR_APT_TRUMP,
                        principalTable: "KR_APTARNAUJANTYS",
                        principalColumn: "APT_TRUMP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INCIDENTU_INF_IST",
                columns: table => new
                {
                    R_INC_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    R_IST_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INCIDENTU_INF_IST", x => new { x.R_INC_ID, x.R_IST_ID });
                    table.ForeignKey(
                        name: "FK_INCIDENTU_INF_IST_INCIDENT~",
                        column: x => x.R_INC_ID,
                        principalTable: "INCIDENTAI",
                        principalColumn: "INC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INCIDENTU_INF_IST_INFORMAC~",
                        column: x => x.R_IST_ID,
                        principalTable: "INFORMACINIAI_ISTEKLIAI",
                        principalColumn: "IST_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SER_TIPAI",
                columns: table => new
                {
                    TIP_TRUMP = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    TIP_IST_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 25, nullable: false),
                    TIP_PAV = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SER_TIPAI", x => x.TIP_TRUMP);
                    table.UniqueConstraint("AK_SER_TIPAI_TIP_IST_ID_TIP_T~", x => new { x.TIP_IST_ID, x.TIP_TRUMP });
                    table.ForeignKey(
                        name: "FK_SER_TIPAI_INFORMACINIAI_IS~",
                        column: x => x.TIP_IST_ID,
                        principalTable: "INFORMACINIAI_ISTEKLIAI",
                        principalColumn: "IST_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SERVERIAI",
                columns: table => new
                {
                    SER_ID = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    SER_PAV = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    SER_TIP_TRUMP = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    SER_IST_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVERIAI", x => x.SER_ID);
                    table.UniqueConstraint("AK_SERVERIAI_SER_IST_ID_SER_ID", x => new { x.SER_IST_ID, x.SER_ID });
                    table.ForeignKey(
                        name: "FK_SERVERIAI_INFORMACINIAI_IS~",
                        column: x => x.SER_IST_ID,
                        principalTable: "INFORMACINIAI_ISTEKLIAI",
                        principalColumn: "IST_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SERVERIAI_SER_TIPAI_SER_IS~",
                        columns: x => new { x.SER_IST_ID, x.SER_TIP_TRUMP },
                        principalTable: "SER_TIPAI",
                        principalColumns: new[] { "TIP_IST_ID", "TIP_TRUMP" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INCIDENTU_SERVERIAI",
                columns: table => new
                {
                    R_INC_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    R_IST_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    R_SER_ID = table.Column<string>(type: "NVARCHAR2(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INCIDENTU_SERVERIAI", x => new { x.R_INC_ID, x.R_IST_ID, x.R_SER_ID });
                    table.ForeignKey(
                        name: "FK_INCIDENTU_SERVERIAI_INCID~1",
                        columns: x => new { x.R_INC_ID, x.R_IST_ID },
                        principalTable: "INCIDENTU_INF_IST",
                        principalColumns: new[] { "R_INC_ID", "R_IST_ID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INCIDENTU_SERVERIAI_INCIDE~",
                        column: x => x.R_INC_ID,
                        principalTable: "INCIDENTAI",
                        principalColumn: "INC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INCIDENTU_SERVERIAI_SERVER~",
                        columns: x => new { x.R_IST_ID, x.R_SER_ID },
                        principalTable: "SERVERIAI",
                        principalColumns: new[] { "SER_IST_ID", "SER_ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INC_GRUPES_GR_GR_ID",
                table: "INC_GRUPES",
                column: "GR_GR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCIDENTAI_INC_POV_ID",
                table: "INCIDENTAI",
                column: "INC_POV_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCIDENTAI_INC_RIZ_ID",
                table: "INCIDENTAI",
                column: "INC_RIZ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCIDENTU_GRUPES_R_INC_ID",
                table: "INCIDENTU_GRUPES",
                column: "R_INC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCIDENTU_INF_IST_R_IST_ID",
                table: "INCIDENTU_INF_IST",
                column: "R_IST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCIDENTU_SERVERIAI_R_IST_~",
                table: "INCIDENTU_SERVERIAI",
                columns: new[] { "R_IST_ID", "R_SER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_INFORMACINIAI_ISTEKLIAI_IS~",
                table: "INFORMACINIAI_ISTEKLIAI",
                column: "IST_TIP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KREIPINIAI_KR_APT_TRUMP",
                table: "KREIPINIAI",
                column: "KR_APT_TRUMP");

            migrationBuilder.CreateIndex(
                name: "IX_KREIPINIAI_KR_INC_ID",
                table: "KREIPINIAI",
                column: "KR_INC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SERVERIAI_SER_IST_ID_SER_T~",
                table: "SERVERIAI",
                columns: new[] { "SER_IST_ID", "SER_TIP_TRUMP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INCIDENTU_GRUPES");

            migrationBuilder.DropTable(
                name: "INCIDENTU_SERVERIAI");

            migrationBuilder.DropTable(
                name: "KREIPINIAI");

            migrationBuilder.DropTable(
                name: "INC_GRUPES");

            migrationBuilder.DropTable(
                name: "INCIDENTU_INF_IST");

            migrationBuilder.DropTable(
                name: "SERVERIAI");

            migrationBuilder.DropTable(
                name: "KR_APTARNAUJANTYS");

            migrationBuilder.DropTable(
                name: "INCIDENTAI");

            migrationBuilder.DropTable(
                name: "SER_TIPAI");

            migrationBuilder.DropTable(
                name: "INC_POVEIKIAI");

            migrationBuilder.DropTable(
                name: "INC_RIZIKOS");

            migrationBuilder.DropTable(
                name: "INFORMACINIAI_ISTEKLIAI");

            migrationBuilder.DropTable(
                name: "INF_IST_TIPAI");
        }
    }
}
