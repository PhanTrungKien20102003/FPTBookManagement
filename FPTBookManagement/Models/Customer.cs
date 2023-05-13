using System.ComponentModel.DataAnnotations;

namespace FPTBookManagement.Models
{
    public class Customer
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }
    }
}
