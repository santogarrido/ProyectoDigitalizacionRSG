using System.ComponentModel.DataAnnotations;

namespace ProyectoDigitalizacion2.Components.Models
{
    public class Productos
    {
        [Key]
        private int Id { get; set; }

        private string Nombre { get; set; }

        private int Cantidad { get; set; }

        private int Precio { get; set;  }

        public Productos() { }
       
    }
}

