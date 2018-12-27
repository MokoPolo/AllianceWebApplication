using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class createdata4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MemberRaidPlacement",
                columns: new[] { "ID", "AllianceMemberID", "Path", "RaidEventID", "RaidLevelID", "StrikeTeam" },
                values: new object[] { 1L, 1L, "A", 1L, 1L, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MemberRaidPlacement",
                keyColumn: "ID",
                keyValue: 1L);
        }
    }
}
