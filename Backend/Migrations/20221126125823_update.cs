using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanlyUser.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Customer",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "CCCD",
                table: "Customer",
                newName: "Price");

            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "Customer",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Customer",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Customer",
                newName: "CCCD");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
