using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllianceWebApplication.Context
{
    public class MemberRaidPlacement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [ForeignKey("RaidEvent")]
        public long RaidEventID { get; set; }
        [ForeignKey("RaidLevel")]
        public long RaidLevelID { get; set; }
        [ForeignKey("AllianceMember")]
        public long AllianceMemberID { get; set; }
        public int StrikeTeam { get; set; }
        public string Path { get; set; }
    }
}
