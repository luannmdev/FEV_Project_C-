using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class AddNewEventModel
    {
        [RegularExpression(@"^[A-Za-z ]+", ErrorMessage = "Title must contain word only")]
        [Required(ErrorMessage = "Title must be filled")]
        public string title { get; set; }
        [RegularExpression(@"^[A-Za-z ]+", ErrorMessage = "Description must contain word only")]
        [Required(ErrorMessage = "Description must be filled")]
        public string description { get; set; }
    }
}
