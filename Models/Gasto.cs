using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseXpertCRUD.Models
{
    public class Gasto
    {
        public int GastoID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; } 
        public Usuario Usuario { get; set; } // Navigation property

        [ForeignKey("Categoria")] 
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; } // Navigation property
        [DataType(DataType.Date)]
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public double Monto { get; set; }

        public string Descripcion { get; set; } = "";
    }
}
