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
            var mainObj = new MainViewModel();
            

            return this.View();
        }

        public ActionResult NewUser()
        {
            // return View(new UsuariosModel().ListaPerfiles = new PerfilUsuarioModel().GetPerfiles());
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


        public JsonResult GetVentanasForIdSubsistema(int idSubsistema)
        {

            var ventanas  = new List<SelectListItem>();
            //var listaVentanas = new SubsistemaModel().GetVentanasForIdsubsistema(idSubsistema);
            //foreach (var item in listaVentanas)
            //{
            //    ventanas.Add(new SelectListItem { Text = item.Descripcion, Value = item.IdVentana.ToString() });
            //} usar cuando se tenga la base poblada
            switch (idSubsistema)
            {
                case 1:
                    ventanas.Add(new SelectListItem { Text = "nominaProduccion", Value = "1" });
                    break;
                case 2:
                    ventanas.Add(new SelectListItem { Text = "nominaDesarrolladores", Value = "2" });
                    break;
                case 3:
                    ventanas.Add(new SelectListItem { Text = "nominaTrainees", Value = "3" });
                    break;
                case 4:
                    ventanas.Add(new SelectListItem { Text = "nominaLiderProyecto", Value = "4" });
                    break;
                default:
                    ventanas.Add(new SelectListItem { Text = "NominaLiderProyecto", Value = "5" });
                    break;
            }

            return Json(new SelectList(ventanas, "Value", "Text"));
        }

        public JsonResult GetControlesForIdVentana(int idVEntana)
        {

            var ventanas = new List<SelectListItem>();
            //var listaVentanas = new SubsistemaModel().GetVentanasForIdsubsistema(idSubsistema);
            //foreach (var item in listaVentanas)
            //{
            //    ventanas.Add(new SelectListItem { Text = item.Descripcion, Value = item.IdVentana.ToString() });
            //} usar cuando se tenga la base poblada
            switch (idVEntana)
            {
                case 1:
                    ventanas.Add(new SelectListItem { Text = "CalcularNominaProduccion", Value = "1" });
                    break;
                case 2:
                    ventanas.Add(new SelectListItem { Text = "CalcularNominaDesarrolladores", Value = "2" });
                    break;
                case 3:
                    ventanas.Add(new SelectListItem { Text = "CalcularNominaArquitectos", Value = "3" });
                    break;
                case 4:
                    ventanas.Add(new SelectListItem { Text = "CalcularNominaTrainees", Value = "4" });
                    break;
                default: ventanas.Add(new SelectListItem { Text = "CalcularNominaLiderProyecto", Value = "5" });
                    break;
            }

            return Json(new SelectList(ventanas, "Value", "Text"));
        }
        
    }
}