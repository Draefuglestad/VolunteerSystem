using System.ComponentModel.DataAnnotations;

namespace VolunteerSystem.Models.ViewModels
{
    public class LoginModel
    {
        public string UserName { get; set; }
        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        public string Email { get; set; }

        public string ReturnUrl { get; set; } = "/";

    }
}
