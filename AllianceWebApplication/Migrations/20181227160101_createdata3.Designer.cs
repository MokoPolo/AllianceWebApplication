﻿// <auto-generated />
using AllianceWebApplication.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AllianceWebApplication.Migrations
{
    [DbContext(typeof(AllianceDbContext))]
    [Migration("20181227160101_createdata3")]
    partial class createdata3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AllianceWebApplication.Context.AllianceMember", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("AllianceMembers");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Active = true,
                            Name = "DadPool"
                        });
                });

            modelBuilder.Entity("AllianceWebApplication.Context.DailyRaidResults", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AllianceMemberID");

                    b.Property<long>("Damage");

                    b.Property<long>("RaidEventID");

                    b.Property<long>("RaidLevelID");

                    b.HasKey("ID");

                    b.ToTable("DailyRaidResults");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            AllianceMemberID = 1L,
                            Damage = 654654L,
                            RaidEventID = 1L,
                            RaidLevelID = 1L
                        });
                });

            modelBuilder.Entity("AllianceWebApplication.Context.MemberRaidPlacement", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AllianceMemberID");

                    b.Property<string>("Path");

                    b.Property<long>("RaidEventID");

                    b.Property<long>("RaidLevelID");

                    b.Property<int>("StrikeTeam");

                    b.HasKey("ID");

                    b.ToTable("MemberRaidPlacement");
                });

            modelBuilder.Entity("AllianceWebApplication.Context.RaidEvent", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.HasKey("ID");

                    b.ToTable("RaidEvents");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Name = "Ultimus"
                        });
                });

            modelBuilder.Entity("AllianceWebApplication.Context.RaidLevel", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Name");

                    b.Property<long>("RaidEventID");

                    b.HasKey("ID");

                    b.ToTable("RaidLevels");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Active = true,
                            Name = "VI",
                            RaidEventID = 1L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
