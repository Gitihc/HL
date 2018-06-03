using Microsoft.EntityFrameworkCore.Migrations;

namespace HL.EntityFrameworkCore.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "abc",
                table: "user",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "abc",
                table: "user");
        }
    }
}
