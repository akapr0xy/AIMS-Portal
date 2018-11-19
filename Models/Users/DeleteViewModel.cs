using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Models.Users
{
    public class DeleteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(64)]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Company { get; set; }
    }
}
