using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionareRegimuri.Migrations
{
    public partial class ContraindicatieFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boala",
                columns: table => new
                {
                    BoalaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boala", x => x.BoalaID);
                });

            migrationBuilder.CreateTable(
                name: "Contraindicatii",
                columns: table => new
                {
                    ContraindicatieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlimentID = table.Column<int>(type: "int", nullable: false),
                    BoalaID = table.Column<int>(type: "int", nullable: false),
                    Motiv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contraindicatii", x => x.ContraindicatieID);
                    table.ForeignKey(
                        name: "FK_Contraindicatii_Aliments_AlimentID",
                        column: x => x.AlimentID,
                        principalTable: "Aliments",
                        principalColumn: "AlimentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contraindicatii_Boala_BoalaID",
                        column: x => x.BoalaID,
                        principalTable: "Boala",
                        principalColumn: "BoalaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Indicatii",
                columns: table => new
                {
                    IndicatiiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlimentID = table.Column<int>(type: "int", nullable: false),
                    BoalaID = table.Column<int>(type: "int", nullable: false),
                    Motiv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicatii", x => x.IndicatiiID);
                    table.ForeignKey(
                        name: "FK_Indicatii_Aliments_AlimentID",
                        column: x => x.AlimentID,
                        principalTable: "Aliments",
                        principalColumn: "AlimentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Indicatii_Boala_BoalaID",
                        column: x => x.BoalaID,
                        principalTable: "Boala",
                        principalColumn: "BoalaID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Contraindicatii_AlimentID",
                table: "Contraindicatii",
                column: "AlimentID");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindicatii_BoalaID",
                table: "Contraindicatii",
                column: "BoalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Indicatii_AlimentID",
                table: "Indicatii",
                column: "AlimentID");

            migrationBuilder.CreateIndex(
                name: "IX_Indicatii_BoalaID",
                table: "Indicatii",
                column: "BoalaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contraindicatii");

            migrationBuilder.DropTable(
                name: "Indicatii");

            migrationBuilder.DropTable(
                name: "Boala");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f0a28ce8-79b9-4e43-88ee-928272b47e4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1b4aed27-be2a-416f-a1b5-5bffe41e1288");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6fcb9398-4d14-4a96-8c42-c214d967d6f8");
        }
    }
}
