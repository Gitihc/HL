using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HL.EntityFrameworkCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "button",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ButtonID = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Title = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    EventName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    MethodName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Index = table.Column<int>(nullable: false),
                    GenTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Creator = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_button", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    DapartmentName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    DapartmentCode = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Mange = table.Column<Guid>(nullable: true),
                    ContactNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Ceator = table.Column<Guid>(nullable: true),
                    GenTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    IsDeleted = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "log",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OpType = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OpUserId = table.Column<Guid>(nullable: false),
                    GenTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Link = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    IsEnable = table.Column<int>(nullable: false, defaultValue: 0),
                    Index = table.Column<int>(nullable: false),
                    GenTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Creator = table.Column<Guid>(nullable: false),
                    ButtonList = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    GenTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Creator = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    LoginName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Password = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    VseName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    GenTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    LoginTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastLoginTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LoginCount = table.Column<long>(nullable: false, defaultValue: 0L),
                    IsDeleted = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "button");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "log");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
