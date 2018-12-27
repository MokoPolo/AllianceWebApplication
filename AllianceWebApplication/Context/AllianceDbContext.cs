using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AllianceWebApplication.Context
{
    public class AllianceDbContext : DbContext
    {
        public AllianceDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<RaidEvent> RaidEvents { get; set; }
        DbSet<RaidLevel> RaidLevels { get; set; }
        DbSet<AllianceMember> AllianceMembers { get; set; }
        DbSet<MemberRaidPlacement> MemberRaidPlacement { get; set; }
        DbSet<DailyRaidResults> DailyRaidResults { get; set; }
        //DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var dadPool = new AllianceMember() { ID = 1, Name = "DadPool", Active = true };
            modelBuilder.Entity<AllianceMember>().HasData(dadPool);

            var ultimusRaid = new RaidEvent() { ID = 1, Name = "Ultimus" };
            modelBuilder.Entity<RaidEvent>().HasData(ultimusRaid);

            var ultimusRaidLevel = new RaidLevel() { ID = 1, Name = "VI", Active = true, RaidEventID = ultimusRaid.ID };
            modelBuilder.Entity<RaidLevel>().HasData(ultimusRaidLevel);

            modelBuilder.Entity<DailyRaidResults>().HasData(
                new DailyRaidResults() { ID = 1, AllianceMemberID = dadPool.ID, RaidEventID = ultimusRaid.ID,
                    RaidLevelID = ultimusRaidLevel.ID, Damage = 654654}
                );

            modelBuilder.Entity<MemberRaidPlacement>().HasData(
                new MemberRaidPlacement() { ID = 1, AllianceMemberID = dadPool.ID, RaidEventID = ultimusRaid.ID,
                    RaidLevelID = ultimusRaidLevel.ID, StrikeTeam = 1, Path = "A"}
                );
            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee() { EmployeeId = 1, Name = "John", Designation = "Developer", Address = "New York", CompanyName = "XYZ Inc", Salary = 30000 },
            //    new Employee() { EmployeeId = 2, Name = "Chris", Designation = "Manager", Address = "New York", CompanyName = "ABC Inc", Salary = 50000 },
            //    new Employee() { EmployeeId = 3, Name = "Mukesh", Designation = "Consultant", Address = "New Delhi", CompanyName = "XYZ Inc", Salary = 20000 });
        }
    }
}
