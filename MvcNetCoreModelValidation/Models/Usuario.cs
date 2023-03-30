using MvcNetCoreModelValidation.Validations;
using System.ComponentModel.DataAnnotations;

namespace MvcNetCoreModelValidation.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Este campo es requerido.")]
        [MinLength(5, ErrorMessage = "El nombre debe tener mínimo 5 caracteres")]
        [MaxLength(10, ErrorMessage = "El nombre debe tener máximo 10 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(4, ErrorMessage = "The ThumbnailPhotoFileName value cannot exceed 4 characters. ")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Range(18,65, ErrorMessage = "La edad comprende entre 18 y 65")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [EmailAddress(ErrorMessage = "Formato incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [ValidationDNI(ErrorMessage = "Formato incorrecto")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$", ErrorMessage = "La contraseña debe tener entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula y al menos una mayúscula.")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Compare("Contraseña", ErrorMessage = "Las contraseñas no coinciden.")]
        public string RepetirContraseña { get; set; }
    }
}
