using System.ComponentModel.DataAnnotations;

namespace inmobiliaria25.Models
{
    public abstract class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        public string Dni { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Telefono { get; set; }
    }
}
