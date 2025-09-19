using System;
using System.Collections.Generic;

namespace TPGestionEmpresa.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public DateOnly? FechaNacimiento { get; set; }
}
