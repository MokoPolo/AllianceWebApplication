using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class addedidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Employees",
                nullable: true);
        }
    }
}
