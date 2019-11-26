using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models.Acciones
{
    public class LlamadaModel
    {
        public int IdLlamada { get; set; }

        public string Nombre { get; set; }

        public bool Estaactivo { get; set; }
    }
}