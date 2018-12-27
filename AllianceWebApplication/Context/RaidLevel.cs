using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllianceWebApplication.Context
{
    public class RaidLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [ForeignKey("RaidEvent")]
        public long RaidEventID { get; set; }
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
