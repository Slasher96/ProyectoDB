using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models
{
    public class AccionesCatModel
    {
        public int CodigoAccion { get; set; }

        public string Descripcion { get; set; }

        public bool EstaActivo { get; set; }
    }
}