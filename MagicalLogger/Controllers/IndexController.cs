using MagicalLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagicalLogger.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MagicalLogger.Models.Usuarios.LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (!new MagicalLogger.Models.Usuarios.LoginModel().ValidateUsuer(model))
                {
                    ViewData["Error en Login"] = "El usuario o Contraseña son incorrectos";
                    return View();
                }
                else
                {
                    return RedirectToAction("MainView");
                }
            }
            return View();
        }

        public ActionResult MainView()
        {
            return this.View();
        }

        public ActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewUser(UsuariosModel model)
        {
            if (ModelState.IsValid)
            {
                new UsuariosModel { ListaPerfiles = new PerfilUsuarioModel().GetPerfiles() };
                new UsuariosModel().AddUser(model);
            }
            return View();
        }
    }
}