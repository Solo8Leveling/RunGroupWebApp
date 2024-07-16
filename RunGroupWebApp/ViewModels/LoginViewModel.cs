using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.ViewModels
{
    public class LoginViewModel
    {
        //moterize daxilinde yazilanlar validation, annotation
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }
        //alt alta yazilan iki setr password'bos buraxilsa signal kimi verir ki, ae password'u yaz, bu data annotations adlanir ve validation'un bir novudu
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
