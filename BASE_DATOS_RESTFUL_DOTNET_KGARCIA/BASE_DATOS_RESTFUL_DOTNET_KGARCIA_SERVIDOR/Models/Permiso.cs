using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Permiso
{
    public string ChrEmplcodigo { get; set; } = null!;

    public int IntModucodigo { get; set; }

    public string VchPermestado { get; set; } = null!;

    public virtual Usuario ChrEmplcodigoNavigation { get; set; } = null!;

    public virtual Modulo IntModucodigoNavigation { get; set; } = null!;
}
