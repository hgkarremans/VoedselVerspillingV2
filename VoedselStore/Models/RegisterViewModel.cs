using System.ComponentModel.DataAnnotations;

namespace VoedselStore.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord herhalen")]
        [Compare("Password", ErrorMessage = "Wachtwoorden komen niet overeen")]
        public string PasswordConfirm { get; set; } = null!;
            
        [Required (ErrorMessage ="Kies een rol")]
        public string UserRole { get; set; } = null!;
    }
}
