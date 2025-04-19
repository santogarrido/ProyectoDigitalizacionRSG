using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDigitalizacion2.Components.Models
{
    [Table("productos")]
    public class Productos
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set;  }

        public Productos() { }
       
    }
}

