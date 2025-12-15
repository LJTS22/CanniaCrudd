using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanniaCrud.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CArgo { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }
    }
}
//comentario