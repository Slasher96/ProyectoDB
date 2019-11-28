using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MagicalLogger.Models;
namespace MagicalLogger.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            var userList = new List<UsuariosModel>();
            userList.Add(new UsuariosModel
            {
                IdUsuario =1,
                NombreUsuario = "Cinthia102742",
                Nombre = "Cinthia",
                PrimerApellido = "Arroyo",
                SegundoApellido = "Garcia",
                NumeroIne = "123456789012",
                Telefono = "5555555555",
                IdPerfil = 1
            });
            userList.Add(new UsuariosModel
            {
                IdUsuario = 2,
                NombreUsuario = "Cinthia102743",
                Nombre = "Cinthiaaaa",
                PrimerApellido = "Arroyo",
                SegundoApellido = "Garcia",
                NumeroIne = "123456789012",
                Telefono = "5555555555",
                IdPerfil = 1
            });
            userList.Add(new UsuariosModel
            {
                IdUsuario = 3,
                NombreUsuario = "Cinthia102744",
                Nombre = "Cinthia",
                PrimerApellido = "Arroyo0",
                SegundoApellido = "Garciaa",
                NumeroIne = "123456789012",
                Telefono = "5555555555",
                IdPerfil = 1
            });

            return View(new UsuariosModel {ListaUsuarios = userList });
        }
    }
}