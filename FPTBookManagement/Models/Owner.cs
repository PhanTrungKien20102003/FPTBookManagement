using System.ComponentModel.DataAnnotations;

namespace FPTBookManagement.Models
{
    public class Owner
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
    }
}
