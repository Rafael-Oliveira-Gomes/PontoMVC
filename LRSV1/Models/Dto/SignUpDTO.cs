using System.ComponentModel.DataAnnotations;

namespace LRSV1.Models.Dto
{
    public class SignUpDTO
    {
        [Required(ErrorMessage = "É necessário o nome.")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "É necessário o e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário a senha.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "É necessário a senha.")]
        public string PasswordConfirm { get; set; }
    }
}
