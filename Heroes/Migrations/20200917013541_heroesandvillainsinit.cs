using Microsoft.EntityFrameworkCore.Migrations;

namespace Heroes.Migrations
{
    public partial class heroesandvillainsinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "heroes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    heroName = table.Column<string>(nullable: true),
                    power = table.Column<string>(nullable: true),
                    howToReach = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_heroes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "villains",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    villainName = table.Column<string>(nullable: true),
                    power = table.Column<string>(nullable: true),
                    howToReach = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_villains", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "heroes");

            migrationBuilder.DropTable(
                name: "villains");
        }
    }
}
