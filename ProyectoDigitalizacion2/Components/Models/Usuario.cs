using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ProyectoDigitalizacion2.Components.Models
{

    [Table("usuarios")]  // ← Esto fuerza a que se use la tabla 'usuarios'
    public class Usuario
        {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "El nombre es obligatorio")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "El email es obligatorio")]
            [EmailAddress(ErrorMessage = "El email es inválido")]
            public string Email { get; set; }

            [Required(ErrorMessage = "La contraseña es obligatoria")]
            public string Contraseña { get; set; }

            public string Rol { get; set; }

            public Usuario() { }

        }
    }

