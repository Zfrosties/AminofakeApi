using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace aminofakeApi.Migrations
{
    public partial class FirstLetterUppercaseonfactsprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fake",
                table: "Facts");

            migrationBuilder.DropColumn(
                name: "validated",
                table: "Facts");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Facts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Facts",
                newName: "Content");

            migrationBuilder.AddColumn<bool>(
                name: "IsFake",
                table: "Facts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsValidated",
                table: "Facts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFake",
                table: "Facts");

            migrationBuilder.DropColumn(
                name: "IsValidated",
                table: "Facts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Facts",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Facts",
                newName: "content");

            migrationBuilder.AddColumn<bool>(
                name: "fake",
                table: "Facts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "validated",
                table: "Facts",
                nullable: false,
                defaultValue: false);
        }
    }
}
