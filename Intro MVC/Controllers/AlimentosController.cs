using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro_MVC.Controllers
{
    public class AlimentosController : Controller
    {
        // GET: Alimentos
        public ActionResult Alta()
        {
            return View();
        }

        public ActionResult Todos()
        {
            List<Alimento> Listado = AlimentosServicios.Hardcodeo();
            return View(Listado);
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult Borrar()
        {
            return View();
        }
    }
}