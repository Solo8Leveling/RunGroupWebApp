using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email is required")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Confirm password")]
        [Required(ErrorMessage ="Confirmation password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password don't match")]
        public string ConfirmPassword { get; set; }

    }
}
