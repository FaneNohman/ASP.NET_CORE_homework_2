using System.ComponentModel.DataAnnotations;
namespace WebApplication_lesson_1.Models
{
    public class Auth
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Invalid login")]
        [Display(Name = "User")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Invalid password")]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        public string? Sex { get; set; }
    }
}
