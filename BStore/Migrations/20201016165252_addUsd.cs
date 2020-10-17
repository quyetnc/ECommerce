using Microsoft.EntityFrameworkCore.Migrations;

namespace BStore.Migrations
{
    public partial class addUsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USD",
                columns: table => new
                {
                    MaUSD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TyGiaUSD = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USD", x => x.MaUSD);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USD");
        }
    }
}
