using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Cuentum
{
    public string ChrCuencodigo { get; set; } = null!;

    public string ChrMonecodigo { get; set; } = null!;

    public string ChrSucucodigo { get; set; } = null!;

    public string ChrEmplcreacuenta { get; set; } = null!;

    public string ChrCliecodigo { get; set; } = null!;

    public decimal DecCuensaldo { get; set; }

    public DateOnly DttCuenfechacreacion { get; set; }

    public string VchCuenestado { get; set; } = null!;

    public int IntCuencontmov { get; set; }

    public string ChrCuenclave { get; set; } = null!;

    public virtual Cliente ChrCliecodigoNavigation { get; set; } = null!;

    public virtual Empleado ChrEmplcreacuentaNavigation { get; set; } = null!;

    public virtual Monedum ChrMonecodigoNavigation { get; set; } = null!;

    public virtual Sucursal ChrSucucodigoNavigation { get; set; } = null!;

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
}
