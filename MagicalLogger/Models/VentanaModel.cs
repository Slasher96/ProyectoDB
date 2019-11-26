using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models
{
    public class VentanaModel
    {
        public int IdVentana { get; set; }

        public string Descripcion { get; set; }

        public int IdControl { get; set; }

        public bool EsVentanaArranque { get; set; }

        public bool EstaActivo { get; set; }
    }
}