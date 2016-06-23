using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
    }
}