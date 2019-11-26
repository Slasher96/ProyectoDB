using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models
{
    public class PermisosModel
    {
        public int IdPermiso { get; set; }
        public int IdSubsistema { get; set; }
        public bool EstaActivo { get; set; }

        public List<PermisosModel> GetPermisos()
        {
            using (var context = new loggerBDEntities())
            {
                List<PermisosModel> listaPermisos = new List<PermisosModel>();
                var Catalogo = context.genPermisos.Where(a => a.estaActivo).ToList();

                foreach (var item in Catalogo)
                {
                    listaPermisos.Add(new PermisosModel
                    {
                        EstaActivo = item.estaActivo,
                        IdPermiso = item.idPermiso,
                        IdSubsistema = item.idsubsistema
                    });
                }
                return listaPermisos;
            }
        }
    }
}