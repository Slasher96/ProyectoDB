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


        public List<VentanaModel> GetVentanasList()
        {
            using (var context = new loggerBDEntities())
            {
                List<VentanaModel> ventanaslist = new List<VentanaModel>();

                foreach (var item in context.genVentana.Where(a=>a.estaActivo).ToList())
                {
                    ventanaslist.Add( new VentanaModel { IdVentana = item.idVentana, Descripcion = item.descripcion, EsVentanaArranque = item.esVentanaArranque });
                }
                return ventanaslist;
            }
        }
    }
}