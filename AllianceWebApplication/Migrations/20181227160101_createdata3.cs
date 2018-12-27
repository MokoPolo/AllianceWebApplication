using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class createdata3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyRaidResults",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RaidEventID = table.Column<long>(nullable: false),
                    RaidLevelID = table.Column<long>(nullable: false),
                    AllianceMemberID = table.Column<long>(nullable: false),
                    Damage = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyRaidResults", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "DailyRaidResults",
                columns: new[] { "ID", "AllianceMemberID", "Damage", "RaidEventID", "RaidLevelID" },
                values: new object[] { 1L, 1L, 654654L, 1L, 1L });

            migrationBuilder.InsertData(
                table: "RaidEvents",
                columns: new[] { "ID", "Name", "Notes" },
                values: new object[] { 1L, "Ultimus", null });

            migrationBuilder.InsertData(
                table: "RaidLevels",
                columns: new[] { "ID", "Active", "Name", "RaidEventID" },
                values: new object[] { 1L, true, "VI", 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyRaidResults");

            migrationBuilder.DeleteData(
                table: "RaidEvents",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "RaidLevels",
                keyColumn: "ID",
                keyValue: 1L);
        }
    }
}
