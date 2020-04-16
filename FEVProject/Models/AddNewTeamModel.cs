using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class AddNewTeamModel
    {
        [RegularExpression(@"^[A-Za-z ]+", ErrorMessage = "Name must contain word only")]
        [Required(ErrorMessage = "Name must be filled")]
        public string name { get; set; }
        [RegularExpression(@"^[A-Za-z ]+", ErrorMessage = "Description must contain word only")]
        [Required(ErrorMessage = "Description must be filled")]
        public string description { get; set; }
    }
}
