using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models
{
    public class UsuariosModel
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el nombre de usuario")]
        [DisplayName("Nombre de Usuario")]
        public string NombreUsuario { get; set; }


        [Required(ErrorMessage = "Por favor ingrese su nombre")]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el primer apellido")]
        [DisplayName("Primer Apellido")]
        public string PrimerApellido { get; set; }

        [DisplayName("Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el número de INE")]
        public string NumeroIne { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Número teléfonico")]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su contraseña")]
        [DisplayName("Contraseña")]
        [MinLength(8, ErrorMessage = "El Nombre de usuario debe tener al menos 10 caracteres")]
        public string Contrasena { get; set; }

        [Required(ErrorMessage = "Por favor confirme su contraseña")]
        [DisplayName("Repetir Contraseña")]
        [MinLength(10, ErrorMessage = "El Nombre de usuario debe tener al menos 10 caracteres")]
        public string RepetirContrasena { get; set; }

        [Required(ErrorMessage = "Por favor seleccione un perfil")]
        [DisplayName("Perfil")]
        public int IdPerfil { get; set; }

        public List<PerfilUsuarioModel> ListaPerfiles { get; set; }

        public PerfilUsuarioModel Perfil { get; set; }
        public bool EstaActivo { get; set; }

        public List<UsuariosModel> ListaUsuarios { get; set; }


        public void AddUser(UsuariosModel usuario)
        {
            using (var context = new loggerBDEntities())
            {
                context.genUsuarios.Add(new genUsuarios
                {
                     // si truena es pro que falta el id usuario
                      nombre = usuario.Nombre
                });
            }
        }

        public List<UsuariosModel> GetUsers()
        {
            var usuarios = new List<UsuariosModel>();
            using (var context = new loggerBDEntities())
            {
                foreach (var item in context.genUsuarios.Where(a => a.estaActivo).ToList())
                {
                    usuarios.Add(new UsuariosModel
                    {
                        IdUsuario = item.idUsuario,
                        NombreUsuario = item.nombreUsuario,
                        Nombre = item.nombre,
                        PrimerApellido = item.primerApellido,
                        SegundoApellido = item.segundoApellido,
                        NumeroIne = item.numeroINE,
                        Telefono = item.telefono,
                        IdPerfil = item.idPerfil
                    });
                }
            }
            return usuarios;
        }

        public void GetUser(int idUsuario)
        {

        }

        public void UpdateUser(UsuariosModel usuario)
        {

        }

        public void DeleteUser(int idUsuer)
        {

        }

        public void MoreusedControl(int idUsuario)
        {

        }

        public void GetexecutedActions()
        {

        }
    }
}