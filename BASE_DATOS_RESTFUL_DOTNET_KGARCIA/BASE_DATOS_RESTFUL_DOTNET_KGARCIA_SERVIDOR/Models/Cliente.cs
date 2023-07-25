using System;
using System.Collections.Generic;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;

public partial class Cliente
{
    public string ChrCliecodigo { get; set; } = null!;

    public string VchCliepaterno { get; set; } = null!;

    public string VchCliematerno { get; set; } = null!;

    public string VchClienombre { get; set; } = null!;

    public string ChrCliedni { get; set; } = null!;

    public string VchClieciudad { get; set; } = null!;

    public string VchCliedireccion { get; set; } = null!;

    public string? VchClietelefono { get; set; }

    public string? VchClieemail { get; set; }

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}
