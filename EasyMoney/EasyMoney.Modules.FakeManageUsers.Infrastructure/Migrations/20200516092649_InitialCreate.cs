using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyMoney.Modules.FakeManageUsers.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ManageUser");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "ManageUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "ManageUser",
                table: "Users",
                columns: new[] { "Id", "Active", "CreatedDate", "Email" },
                values: new object[] { new Guid("6f2e57b7-7609-4caf-98c5-d05ec368da4c"), true, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "email@com.pl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "ManageUser");
        }
    }
}
