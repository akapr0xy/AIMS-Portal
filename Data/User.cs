using System.ComponentModel.DataAnnotations;

namespace AIMS_Portal.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Email { get; set; }


        public string Password { get; set; }

        public string Company { get; set; }

        public string Role { get; set; }
    }
}