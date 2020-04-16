using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace FEVProject.Models
{
    public class User
    {                
        public string username { get; set; }        
        public string password { get; set; }        
        public int role { get; set; }        
        public string fullName { get; set; }        
        public string email { get; set; }
        public string phone { get; set; }
        public string birthdate { get; set; }
        public bool disabled { get; set; }
    }
}
