using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Parametro
{
    public string ChrParacodigo { get; set; } = null!;

    public string VchParadescripcion { get; set; } = null!;

    public string VchParavalor { get; set; } = null!;

    public string VchParaestado { get; set; } = null!;
}
