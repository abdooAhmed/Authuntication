using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Authuntication.Data.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                schema: "security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District",
                schema: "security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Img",
                schema: "security",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                schema: "security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Country",
                schema: "security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "District",
                schema: "security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Img",
                schema: "security",
                table: "Users");
        }
    }
}
