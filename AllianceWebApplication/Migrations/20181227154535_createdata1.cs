using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class createdata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AllianceMembers",
                columns: new[] { "ID", "Active", "Name" },
                values: new object[] { -1L, true, "DadPool" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AllianceMembers",
                keyColumn: "ID",
                keyValue: -1L);
        }
    }
}
