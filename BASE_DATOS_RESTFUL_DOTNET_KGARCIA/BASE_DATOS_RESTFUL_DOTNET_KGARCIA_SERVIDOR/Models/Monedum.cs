using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Monedum
{
    public string ChrMonecodigo { get; set; } = null!;

    public string VchMonedescripcion { get; set; } = null!;

    public virtual Cargomantenimiento? Cargomantenimiento { get; set; }

    public virtual Costomovimiento? Costomovimiento { get; set; }

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    public virtual Interesmensual? Interesmensual { get; set; }
}
