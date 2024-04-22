using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_CRUD_1.Models
{
    public class CreateGastoViewModel
    {
        public Gasto gasto { get; set; }
        public List<SelectListItem> CategoriasLista { get; set; }
    }
}