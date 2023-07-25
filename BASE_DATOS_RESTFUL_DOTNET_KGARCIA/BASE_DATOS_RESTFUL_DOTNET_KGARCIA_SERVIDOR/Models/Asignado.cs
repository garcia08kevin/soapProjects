using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Asignado
{
    public string ChrAsigcodigo { get; set; } = null!;

    public string ChrSucucodigo { get; set; } = null!;

    public string ChrEmplcodigo { get; set; } = null!;

    public DateOnly DttAsigfechaalta { get; set; }

    public DateOnly? DttAsigfechabaja { get; set; }

    public virtual Empleado ChrEmplcodigoNavigation { get; set; } = null!;

    public virtual Sucursal ChrSucucodigoNavigation { get; set; } = null!;
}
