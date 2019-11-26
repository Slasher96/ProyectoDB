using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagicalLogger.Models.Usuarios
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Por favor ingrese el nombre de usuario")]
        [DisplayName("Nombre de Usuario")]
        public string NombreUsuario { get; set; }


        [Required(ErrorMessage = "Por favor ingrese su contraseña")]
        [DisplayName("Contraseña")]
        public string Contrasena { get; set; }



        public bool ValidateUsuer(LoginModel user)
        {
            using (var context = new loggerBDEntities())
            {
                if (context.genUsuarios.Any(thisUser => thisUser.nombreUsuario == user.NombreUsuario && user.Contrasena == thisUser.contrasena))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}