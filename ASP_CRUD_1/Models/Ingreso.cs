//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_CRUD_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Ingreso
    {
        public int IngresoID { get; set; }
        public int UsuarioID { get; set; }
        public int CategoriaID { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
