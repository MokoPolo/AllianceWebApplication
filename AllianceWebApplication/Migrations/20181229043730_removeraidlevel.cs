using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class removeraidlevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaidLevels");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "RaidEvents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DailyRaidResults",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RaidLevelID",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "MemberRaidPlacement",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RaidLevelID",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "RaidEvents",
                keyColumn: "ID",
                keyValue: 1L,
                column: "Active",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "RaidEvents");

            migrationBuilder.CreateTable(
                name: "RaidLevels",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RaidEventID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidLevels", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "DailyRaidResults",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RaidLevelID",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "MemberRaidPlacement",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RaidLevelID",
                value: 1L);

            migrationBuilder.InsertData(
                table: "RaidLevels",
                columns: new[] { "ID", "Active", "Name", "RaidEventID" },
                values: new object[] { 1L, true, "VI", 1L });
        }
    }
}
