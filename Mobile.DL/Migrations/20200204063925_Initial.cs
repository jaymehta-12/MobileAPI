using Microsoft.EntityFrameworkCore.Migrations;

namespace Mobile.DL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MobileItems",
                columns: table => new
                {
                    MobileItemsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileName = table.Column<string>(nullable: true),
                    MobilePrice = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileItems", x => x.MobileItemsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobileItems");
        }
    }
}
