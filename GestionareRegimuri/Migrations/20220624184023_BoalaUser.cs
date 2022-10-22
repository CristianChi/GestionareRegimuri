using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionareRegimuri.Migrations
{
    public partial class BoalaUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Mesaje",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "BoalaUser",
                columns: table => new
                {
                    BoliBoalaID = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoalaUser", x => new { x.BoliBoalaID, x.UsersId });
                    table.ForeignKey(
                        name: "FK_BoalaUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoalaUser_Boala_BoliBoalaID",
                        column: x => x.BoliBoalaID,
                        principalTable: "Boala",
                        principalColumn: "BoalaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f7222155-14c2-453a-b8bc-0675d967719f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1abfb1cf-6904-4eca-a37f-93e4f8dbab46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a14a4f6e-5d52-4f67-93ea-40e2eb968f3f");

            migrationBuilder.CreateIndex(
                name: "IX_Mesaje_UserID",
                table: "Mesaje",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BoalaUser_UsersId",
                table: "BoalaUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesaje_AspNetUsers_UserID",
                table: "Mesaje",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mesaje_AspNetUsers_UserID",
                table: "Mesaje");

            migrationBuilder.DropTable(
                name: "BoalaUser");

            migrationBuilder.DropIndex(
                name: "IX_Mesaje_UserID",
                table: "Mesaje");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Mesaje",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
        }
    }
}
