using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Modulo
{
    public int IntModucodigo { get; set; }

    public string? VchModunombre { get; set; }

    public string VchModuestado { get; set; } = null!;

    public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();
}
