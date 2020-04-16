using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class Comment
    {
        public string commentId { get; set; }
        public int taskId { get; set; }
        public string owner { get; set; }
        public string description { get; set; }
    }
}
