using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class Team
    {
        public int teamId { get; set; }
        public int eventId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
