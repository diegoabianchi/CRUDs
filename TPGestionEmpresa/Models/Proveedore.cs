using System;
using System.Collections.Generic;

namespace TPGestionEmpresa.Models;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string NombreCompleto => $"{Nombre} {Apellido}"; //Propiedad calculada
    public string? Telefono { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
