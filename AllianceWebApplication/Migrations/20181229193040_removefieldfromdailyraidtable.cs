using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class removefieldfromdailyraidtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaidLevelID",
                table: "DailyRaidResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RaidLevelID",
                table: "DailyRaidResults",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
