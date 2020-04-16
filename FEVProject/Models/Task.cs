using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class Task
    {
        public int taskId { get; set; }
        public int teamId { get; set; }
        public string owner { get; set; }
        public string receiver { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string description { get; set; }
        public bool accepted { get; set; }
        public bool done { get; set; }
    }
}
