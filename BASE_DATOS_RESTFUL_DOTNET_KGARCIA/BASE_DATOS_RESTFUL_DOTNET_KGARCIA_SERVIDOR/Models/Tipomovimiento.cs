using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Tipomovimiento
{
    public string ChrTipocodigo { get; set; } = null!;

    public string VchTipodescripcion { get; set; } = null!;

    public string VchTipoaccion { get; set; } = null!;

    public string VchTipoestado { get; set; } = null!;

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
}
