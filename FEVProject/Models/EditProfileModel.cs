using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FEVProject.Models
{
    public class EditProfileModel
    {
        [RegularExpression(@"^[A-Za-z ]+", ErrorMessage = "Name must contain word only")]
        [Required(ErrorMessage = "Name must be filled")]
        public string fullName { get; set; }        
        [Required(ErrorMessage = "Email must be filled")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string email { get; set; }
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone must contain 10-number")]
        [Required(ErrorMessage = "Phone must be filled")]
        public string phone { get; set; }
        [Required]
        public string birthdate { get; set; }
    }
}
