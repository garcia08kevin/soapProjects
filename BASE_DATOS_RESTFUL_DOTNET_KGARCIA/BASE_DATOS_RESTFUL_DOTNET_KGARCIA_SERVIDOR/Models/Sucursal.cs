using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Sucursal
{
    public string ChrSucucodigo { get; set; } = null!;

    public string VchSucunombre { get; set; } = null!;

    public string VchSucuciudad { get; set; } = null!;

    public string? VchSucudireccion { get; set; }

    public int IntSucucontcuenta { get; set; }

    public virtual ICollection<Asignado> Asignados { get; set; } = new List<Asignado>();

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}
