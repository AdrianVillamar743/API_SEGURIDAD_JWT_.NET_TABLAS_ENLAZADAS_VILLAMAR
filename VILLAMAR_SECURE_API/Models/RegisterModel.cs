using System.ComponentModel.DataAnnotations;

namespace VILLAMAR_SECURE_API.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Nombre de usuario requerido")]
        public string UserName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email requerida")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Clave requerida")]
        public string Password { get; set; }
    }
}
