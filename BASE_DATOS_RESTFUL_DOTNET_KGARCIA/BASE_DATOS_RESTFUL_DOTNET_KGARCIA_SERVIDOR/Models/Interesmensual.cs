using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Interesmensual
{
    public string ChrMonecodigo { get; set; } = null!;

    public decimal DecInteimporte { get; set; }

    public virtual Monedum ChrMonecodigoNavigation { get; set; } = null!;
}
