using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models
{
    public class PerfilUsuarioModel
    {
        public int IdPerfil { get; set; }
        public string Descripcion { get; set; }
        public List<PermisosModel> ListaPermisos { get; set; }
        public bool EstaActivo { get; set; }

        public List<PerfilUsuarioModel> GetPerfiles()
        {
            using (var context = new loggerBDEntities())
            {
                var listaPerfiles = new List<PerfilUsuarioModel>();
                var listaPerfil = context.genPerfilUsuario.Where(a => a.estaActivo).ToList();

                foreach (var item in listaPerfil)
                {
                    listaPerfiles.Add(new PerfilUsuarioModel
                    {
                        IdPerfil = item.idPerfil,
                        EstaActivo = item.estaActivo,
                        Descripcion = item.descripcion,
                        ListaPermisos = new PermisosModel().GetPermisos()
                    }); ;
                }

                return listaPerfiles;
            }
        }
    }
}