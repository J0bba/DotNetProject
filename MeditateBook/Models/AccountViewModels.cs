using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeditateBook.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Mémoriser ce navigateur ?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "email_field", ResourceType = typeof(Resources.Views.Account.Login))]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "password_field", ResourceType = typeof(Resources.Views.Account.Login))]
        public string Password { get; set; }

        [Display(Name = "Mémoriser le mot de passe ?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "email_field", ResourceType = typeof(Resources.Views.Account.Register))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceName = "password_require", ErrorMessageResourceType = typeof(Resources.Views.Account.Register))]
        [DataType(DataType.Password)]
        [Display(Name = "password_field", ResourceType =typeof(Resources.Views.Account.Register))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "confirm_field", ResourceType =typeof(Resources.Views.Account.Register))]
        [Compare("Password", ErrorMessageResourceName = "confirm_require", ErrorMessageResourceType = typeof(Resources.Views.Account.Register))]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "firstname_field", ResourceType =typeof(Resources.Views.Account.Register))]
        public string Firstname { get; set; }

        [Required]
        [Display(Name = "lastname_field", ResourceType =typeof(Resources.Views.Account.Register))]
        public string Lastname { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe")]
        [Compare("Password", ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
