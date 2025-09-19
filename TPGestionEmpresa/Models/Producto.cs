using System;
using System.Collections.Generic;

namespace TPGestionEmpresa.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public int? IdProveedor { get; set; }

    public virtual Proveedore? IdProveedorNavigation { get; set; }
}
