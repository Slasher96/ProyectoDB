using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models
{
    public class MainViewModel
    {

        public const int boton = 1;

        public const int item = 2;

        MainViewModel()
        {
            foreach (var item in new loggerBDEntities().genSubsistemas.Where(a => a.estaActivo).ToList())
            {
                ListaSubsistemas.Add(new SubsistemaModel
                {
                    IdSubsistema = item.idSubsistema,
                    Descripcion = item.descripcion,
                    EstaActivo = item.estaActivo
                });
            }
        }

        public List<SubsistemaModel> ListaSubsistemas { get; set; }

        public List<VentanaModel> ListaVentanas { get; set; }

        public List<Models.Controles.ControlesModel> ListaControles { get; set; }

        [Required(ErrorMessage = "Por favor seleccione un subsistema")]
        [DisplayName("Susbistema")]
        public SubsistemaModel Subsistema { get; set; }

        [Required(ErrorMessage = "Por favor seleccione una Ventana")]
        [DisplayName("Ventana")]
        public VentanaModel Ventana { get; set; }

        [Required(ErrorMessage = "Por favor seleccione un control")]
        [DisplayName("Control")]
        public Models.Controles.ControlesModel Control { get; set; }
    }
}