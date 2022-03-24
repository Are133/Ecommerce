using System.ComponentModel.DataAnnotations;

namespace ecommerce.Common.Entities
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} no puede estar vacio.")]
        [MaxLength(40, ErrorMessage = "No puedes ingresar mas de {1} caracteres")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido paterno")]
        [Required(ErrorMessage = "El campo {0} no puede estar vacio.")]
        [MaxLength(40, ErrorMessage = "No puedes ingresar mas de {1} caracteres")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El campo {0} no puede estar vacio.")]
        [MaxLength(150, ErrorMessage = "No puedes ingresar mas de {1} caracteres")]
        public string Email { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(300, ErrorMessage = "No puedes ingresar mas de {1} caracteres")]
        public string Address { get; set; }

        [Display(Name = "Telefono")]
        [Phone]
        [MaxLength(10, ErrorMessage = "No puedes ingresar mas de {1} caracteres")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Es Activo")]
        public bool IsActive { get; set; }

        [Display(Name = "Es Administrador")]
        public bool IsAdmin { get; set; }

        [Display(Name = "Foto")]
        public string PhotoUrl { get; set; }
    }
}
