using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class removefieldfromdailyraidtable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaidLevelID",
                table: "MemberRaidPlacement");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RaidLevelID",
                table: "MemberRaidPlacement",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
