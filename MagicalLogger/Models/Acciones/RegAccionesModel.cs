using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models.Acciones
{
    public class RegAccionesModel
    {
        public int IdAccion { get; set; }

        public int CodigoAccion { get; set; }

        public int IdLlamada { get; set; }

        public int IdFuncion { get; set; }

        public int TipoAccion { get; set; }

        public DateTime FechaEjecucion { get; set; }
    }
}