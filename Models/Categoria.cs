using System.ComponentModel.DataAnnotations;

namespace ExpenseXpertCRUD.Models{
    public class Categoria{
        public int CategoriaID { get; set; }
        [Required]
        public string Nombre { get; set; }  = "";
    }
}