using System.ComponentModel.DataAnnotations;

namespace PCStore.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a first name.")]
        public string Firstname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        public string Lastname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
