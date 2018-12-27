using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllianceWebApplication.Migrations
{
    public partial class initialalliancestructure3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "MemberRaidPlacement",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RaidEventID = table.Column<long>(nullable: false),
                    RaidLevelID = table.Column<long>(nullable: false),
                    AllianceMemberID = table.Column<long>(nullable: false),
                    StrikeTeam = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberRaidPlacement", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberRaidPlacement");

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
    }
}
