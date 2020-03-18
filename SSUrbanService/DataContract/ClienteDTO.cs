using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSUrbanService.DataContract
{
    public class InmuebleDTO
    {
        public string Expediente { get; set; }
        public DateTime Fecha { get; set; }
        public string Localidad { get; set; }
        public string Descripcion { get; set; }
        public string VendedorArrendador { get; set; }
        public string CompradorArrendatario { get; set; }
        public int TipoInmueble { get; set; }
        public long EstateCounter { get; set; }
    }
}