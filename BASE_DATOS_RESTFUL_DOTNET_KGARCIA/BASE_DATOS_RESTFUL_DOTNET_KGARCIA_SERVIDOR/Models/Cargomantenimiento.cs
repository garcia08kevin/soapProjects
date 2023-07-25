using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Cargomantenimiento
{
    public string ChrMonecodigo { get; set; } = null!;

    public decimal DecCargMontoMaximo { get; set; }

    public decimal DecCargImporte { get; set; }

    public virtual Monedum ChrMonecodigoNavigation { get; set; } = null!;
}
