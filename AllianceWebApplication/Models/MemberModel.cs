using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllianceWebApplication.Models
{
    public class MemberModel
    {
        public long ID { get; set; }
        [Required]
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
