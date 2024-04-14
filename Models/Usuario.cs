using System.ComponentModel.DataAnnotations;

namespace ExpenseXpertCRUD.Models{
    public class Usuario{
        public int UsuarioID { get; set; }
        [Required]
        public string Nombre { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}