using Microsoft.EntityFrameworkCore.Migrations;

namespace DavetiyeDataAccess.Migrations
{
    public partial class tetdbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Davetiyes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KatilimciAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KatilimciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KatilimciTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    katılım = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Davetiyes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Davetiyes");
        }
    }
}
