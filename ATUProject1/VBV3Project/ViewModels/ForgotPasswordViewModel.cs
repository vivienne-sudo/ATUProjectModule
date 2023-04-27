using System.ComponentModel.DataAnnotations;

namespace VBV3Project.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}


