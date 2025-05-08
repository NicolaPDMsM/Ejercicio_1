using System;
using System.Collections.Generic;

namespace Ejemplo_1.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly FechaRegistro { get; set; }

    public int Telefono { get; set; }
}
