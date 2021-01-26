using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocktails.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GlassType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IngredientType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "IngredientDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CocktailName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientDescriptions_Cocktails_CocktailName",
                        column: x => x.CocktailName,
                        principalTable: "Cocktails",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IngredientDescriptions_Ingredients_IngredientName",
                        column: x => x.IngredientName,
                        principalTable: "Ingredients",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientDescriptions_CocktailName",
                table: "IngredientDescriptions",
                column: "CocktailName");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientDescriptions_IngredientName",
                table: "IngredientDescriptions",
                column: "IngredientName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientDescriptions");

            migrationBuilder.DropTable(
                name: "Cocktails");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
