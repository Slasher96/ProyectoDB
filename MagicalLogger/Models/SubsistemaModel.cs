using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models
{
    public class SubsistemaModel
    {
        public int IdSubsistema { get; set; }

        public string Descripcion { get; set; }

        public List<VentanaModel> ListaVentanas { get; set; }

        public bool EstaActivo { get; set; }
    }
}