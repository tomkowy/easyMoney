using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyMoney.Modules.FakeNotifications.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Notifications");

            migrationBuilder.CreateTable(
                name: "Emails",
                schema: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Addresses = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Notifications",
                table: "Emails",
                columns: new[] { "Id", "Addresses", "Body", "Subject" },
                values: new object[] { new Guid("bcd0f82f-de11-4d0e-9127-968ac7374fd8"), "email1@com.pl;email2@com.pl;email3@com.pl", "lorem ipsum, lorem ipsum", "Perfect subject!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails",
                schema: "Notifications");
        }
    }
}
