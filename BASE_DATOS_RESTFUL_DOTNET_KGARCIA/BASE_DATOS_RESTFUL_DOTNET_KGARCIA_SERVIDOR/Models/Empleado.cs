using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Empleado
{
    public string ChrEmplcodigo { get; set; } = null!;

    public string VchEmplpaterno { get; set; } = null!;

    public string VchEmplmaterno { get; set; } = null!;

    public string VchEmplnombre { get; set; } = null!;

    public string VchEmplciudad { get; set; } = null!;

    public string? VchEmpldireccion { get; set; }

    public virtual ICollection<Asignado> Asignados { get; set; } = new List<Asignado>();

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    public virtual ICollection<Logsession> Logsessions { get; set; } = new List<Logsession>();

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

    public virtual Usuario? Usuario { get; set; }
}
