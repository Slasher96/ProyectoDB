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


        public List<VentanaModel> GetVentanasForIdsubsistema(int idSubsistema)
        {
            using (var context = new loggerBDEntities())
            {
                List<VentanaModel> ventanaslist = new List<VentanaModel>();
                var listaventanasPorSubsistema = context.genSubsistemas.Include("genVentana").Where(a => a.estaActivo && a.idSubsistema == idSubsistema).ToList();
                foreach (var item in listaventanasPorSubsistema)
                {
                    ventanaslist.Add(new VentanaModel
                    {
                        IdVentana = item.genVentana.idVentana,
                        Descripcion = item.genVentana.descripcion,
                        EsVentanaArranque = item.genVentana.esVentanaArranque
                    });
                }
                return ventanaslist;
            }
        }


        public List<Controles.ControlesModel> GetControlesForIdVentana(int idVentana)
        {
            using (var context = new loggerBDEntities())
            {
                var listacontroles = new List<Controles.ControlesModel>();
                var listaControlesventana = context.genVentana.Include("regControles").Where(a => a.estaActivo && a.idVentana == idVentana).ToList();
                foreach (var item in listaControlesventana)
                {
                    listacontroles.Add(new Controles.ControlesModel
                    {
                        IdControl = item.regcontroles.idControl,
                        Descripcion = item.regcontroles.descripcion,
                        TextoItemBoton = item.regcontroles.texto,
                        TipoInteraccion = item.regcontroles.tipoInteraccion,
                        IdAccion = item.regcontroles.idAccion
                    });
                }

                return listacontroles;
            }

        }
    }
}