using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chefs_N_Dishes.Migrations
{
    public partial class ChefsNDishesSecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chefs",
                columns: table => new
                {
                    Chef_ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Chef_FirstName = table.Column<string>(nullable: true),
                    Chef_LastName = table.Column<string>(nullable: true),
                    Chef_Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chefs", x => x.Chef_ID);
                });

            migrationBuilder.CreateTable(
                name: "dishes",
                columns: table => new
                {
                    Food_ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Food_Name = table.Column<string>(nullable: true),
                    Calories = table.Column<int>(nullable: false),
                    Tastiness = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Chef_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishes", x => x.Food_ID);
                    table.ForeignKey(
                        name: "FK_dishes_chefs_Chef_ID",
                        column: x => x.Chef_ID,
                        principalTable: "chefs",
                        principalColumn: "Chef_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dishes_Chef_ID",
                table: "dishes",
                column: "Chef_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dishes");

            migrationBuilder.DropTable(
                name: "chefs");
        }
    }
}
