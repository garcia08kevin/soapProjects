using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASE_DATOS_RESTFUL_DOTNET_JACOME_LOAIZA_GARCIA_CLIENTE
{
    internal class JsonResult
    {
        public string ChrCuencodigo { get; set; }
        public string IntMovinumero { get; set; }
        public DateOnly DttMovifecha { get; set; }
        public string ChrTipocodigo { get; set; }
        public string Accion { get; set; }
        public decimal DecMoviimporte { get; set; }
    }
}
