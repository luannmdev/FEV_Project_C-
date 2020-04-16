using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class Event
    {
        public int eventId { get; set; }
        public string username { get; set; }
        public bool done { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
