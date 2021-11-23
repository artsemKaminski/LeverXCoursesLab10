using Microsoft.EntityFrameworkCore.Migrations;

namespace LeverXCoursesLab10.Migrations
{
    public partial class UsersTableRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UsersTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersTable",
                table: "UsersTable",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersTable",
                table: "UsersTable");

            migrationBuilder.RenameTable(
                name: "UsersTable",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
