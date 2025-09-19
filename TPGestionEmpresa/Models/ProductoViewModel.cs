using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEmpresa.Models
{
    public class ProductoViewModel
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal? Precio { get; set; }
        public int Stock { get; set; }
        public string NombreProveedor { get; set; }
    }
}
