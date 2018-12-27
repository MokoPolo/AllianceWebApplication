using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class initialalliancestructure2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AllianceMembers",
                table: "AllianceMembers");

            migrationBuilder.RenameTable(
                name: "AllianceMembers",
                newName: "AllianceMember");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllianceMember",
                table: "AllianceMember",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AllianceMember",
                table: "AllianceMember");

            migrationBuilder.RenameTable(
                name: "AllianceMember",
                newName: "AllianceMembers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllianceMembers",
                table: "AllianceMembers",
                column: "ID");
        }
    }
}
