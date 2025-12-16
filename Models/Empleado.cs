using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanniaCrud.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El cargo es obligatorio")]
        public required string Cargo { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = false)]
        public decimal Salario { get; set; }
    }
}


