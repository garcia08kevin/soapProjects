using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Logsession
{
    public int Id { get; set; }

    public string ChrEmplcodigo { get; set; } = null!;

    public DateTime FecIngreso { get; set; }

    public DateTime? FecSalida { get; set; }

    public string Ip { get; set; } = null!;

    public string Hostname { get; set; } = null!;

    public virtual Empleado ChrEmplcodigoNavigation { get; set; } = null!;
}
