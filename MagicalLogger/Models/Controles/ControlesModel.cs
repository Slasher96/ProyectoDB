using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models.Controles
{
    public class ControlesModel
    {
        public int IdControl { get; set; }

        public string Descripcion { get; set; }

        public string TextoItemBoton { get; set; }

        public int TipoInteraccion { get; set; }

        public int IdAccion { get; set; }
    }
}