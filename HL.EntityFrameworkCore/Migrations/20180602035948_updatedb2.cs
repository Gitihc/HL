using Microsoft.EntityFrameworkCore.Migrations;

namespace HL.EntityFrameworkCore.Migrations
{
    public partial class updatedb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "abc",
                table: "user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "abc",
                table: "user",
                nullable: false,
                defaultValue: 0);
        }
    }
}
