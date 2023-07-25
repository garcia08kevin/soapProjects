using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Movimiento
{
    public string ChrCuencodigo { get; set; } = null!;

    public int IntMovinumero { get; set; }

    public DateOnly DttMovifecha { get; set; }

    public string ChrEmplcodigo { get; set; } = null!;

    public string ChrTipocodigo { get; set; } = null!;

    public decimal DecMoviimporte { get; set; }

    public string? ChrCuenreferencia { get; set; }

    public Cuentum? ChrCuencodigoNavigation { get; set; }

    public Empleado? ChrEmplcodigoNavigation { get; set; }

    public Tipomovimiento? TipoMovimiento { get; set; }
}
