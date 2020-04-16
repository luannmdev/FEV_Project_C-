using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class TeamMember
    {               
        public int teamId { get; set; }        
        public string username { get; set; }
        public int role { get; set; }
        public User User { get; set; }   
        public Team Team { get; set; }
    }
}
