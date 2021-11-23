using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeverXCoursesLab10.Migrations
{
    public partial class AddDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age_changed_name", "EducationLevel", "Name" },
                values: new object[] { new Guid("a7817fa7-e518-4280-abc4-da14f23638e5"), 19, "School+", "Egor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7817fa7-e518-4280-abc4-da14f23638e5"));
        }
    }
}
