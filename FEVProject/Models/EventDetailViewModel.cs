using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEVProject.Models
{
    public class EventDetailViewModel
    {
        public Event Event { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
