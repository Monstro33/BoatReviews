using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoatReviews.Migrations.Category
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryImageLocation = table.Column<string>(nullable: true),
                    CategoryContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryContent", "CategoryImageLocation", "CategoryName" },
                values: new object[] { 1, "Motorboats, also known as speedboats and powerboats, are boats propelled by an internal combustion or electric engine. Their length ranges from about 7 feet to 197 feet, while anything larger is called a ship. They are used recreationally and for sport, and come in many types, shapes, and sizes.", "Img/Motorboat1.jpeg", "Motorboats" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryContent", "CategoryImageLocation", "CategoryName" },
                values: new object[] { 2, "Sailboats are boats propelled partly or entirely by sails. They range in length from about 6 feet to 400 feet, the longer of which are called sailing ships. They are used recreationally and for sport and come in many types, shapes, and sizes.", "Img/Sailboat1.jpeg", "Sailboat" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryContent", "CategoryImageLocation", "CategoryName" },
                values: new object[] { 3, "Human-powered boats are propelled by human power. Human power is harnessed directly from the hands or feet, or through the hands and feet with oars, paddles, poles, pedals, or treadles. Their length ranges from about 3 feet to 144 feet. The are used recreationally and for sport and come in many types, shapes, and sizes.", "Img/HPB1.jpg", "Human Powered Boat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
