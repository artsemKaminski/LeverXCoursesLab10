using Microsoft.EntityFrameworkCore.Migrations;

namespace LeverXCoursesLab10.Migrations
{
    public partial class AddEducationLevelToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EducationLevel",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationLevel",
                table: "Users");
        }
    }
}
