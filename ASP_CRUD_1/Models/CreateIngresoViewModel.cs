using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_CRUD_1.Models
{
    public class CreateIngresoViewModel
    {
       public Ingreso ingreso { get; set; }
       public List<SelectListItem> CategoriasLista { get; set; }
    }
}