using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdminPortal.API.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Student",
                newName: "ProfileImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileImageUrl",
                table: "Student",
                newName: "MyProperty");
        }
    }
}
