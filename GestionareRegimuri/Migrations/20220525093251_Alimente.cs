using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionareRegimuri.Migrations
{
    public partial class Alimente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "AlimentID", "Nume", "Categorie", "Glucide", "Proteine", "Lipide", "Calorii" },
                values: new object[,]
                {
                    { 1, "Andive", "Legume", 3, 2, 0, 20 }
                }
            );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
