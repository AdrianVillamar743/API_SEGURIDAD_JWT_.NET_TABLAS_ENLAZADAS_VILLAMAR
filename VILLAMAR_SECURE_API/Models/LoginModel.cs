using System.ComponentModel.DataAnnotations;

namespace VILLAMAR_SECURE_API.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Usuario es requerido")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Clave requerida")]

        public string Password { get; set; }
    }
}
