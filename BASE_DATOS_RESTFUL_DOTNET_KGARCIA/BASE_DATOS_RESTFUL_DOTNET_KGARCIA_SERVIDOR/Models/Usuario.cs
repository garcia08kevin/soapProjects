using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Usuario
{
    public string ChrEmplcodigo { get; set; } = null!;

    public string VchEmplusuario { get; set; } = null!;

    public string VchEmplclave { get; set; } = null!;

    public string? VchEmplestado { get; set; }

    public virtual Empleado ChrEmplcodigoNavigation { get; set; } = null!;

    public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();
}
