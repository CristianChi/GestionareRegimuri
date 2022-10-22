using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionareRegimuri.Migrations
{
    public partial class Forum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    DiscutieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.DiscutieID);
                    table.ForeignKey(
                        name: "FK_Forums_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Retete",
                columns: table => new
                {
                    RetetaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RetetaNume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retete", x => x.RetetaID);
                });

            migrationBuilder.CreateTable(
                name: "Mesaje",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ForumID = table.Column<int>(type: "int", nullable: false),
                    MesajScris = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesaje", x => x.MesajID);
                    table.ForeignKey(
                        name: "FK_Mesaje_Forums_ForumID",
                        column: x => x.ForumID,
                        principalTable: "Forums",
                        principalColumn: "DiscutieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoalaReteta",
                columns: table => new
                {
                    BoliBoalaID = table.Column<int>(type: "int", nullable: false),
                    ReteteRetetaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoalaReteta", x => new { x.BoliBoalaID, x.ReteteRetetaID });
                    table.ForeignKey(
                        name: "FK_BoalaReteta_Boala_BoliBoalaID",
                        column: x => x.BoliBoalaID,
                        principalTable: "Boala",
                        principalColumn: "BoalaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoalaReteta_Retete_ReteteRetetaID",
                        column: x => x.ReteteRetetaID,
                        principalTable: "Retete",
                        principalColumn: "RetetaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d8f46f08-2126-4ce9-b212-17554cf8a46e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a0815340-8356-4236-9050-8b5c8ca3e2dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "38826081-cc1a-46b1-b753-e1808f13b8a7");

            migrationBuilder.CreateIndex(
                name: "IX_BoalaReteta_ReteteRetetaID",
                table: "BoalaReteta",
                column: "ReteteRetetaID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserID",
                table: "Forums",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Mesaje_ForumID",
                table: "Mesaje",
                column: "ForumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoalaReteta");

            migrationBuilder.DropTable(
                name: "Mesaje");

            migrationBuilder.DropTable(
                name: "Retete");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2bc2dfc3-3045-4cf6-9154-19e31062e38d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4e9942f3-2ed4-4c01-bfa9-a8da9be38215");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5044c14d-599d-4b37-8fe0-6ecd83f6e08e");
        }
    }
}
