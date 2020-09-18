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
            int numeroOrden = AlimentosServicios.UltimoId();
            ViewBag.numeroOrden = numeroOrden;
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Alimento alimento)
        {
            AlimentosServicios.Alta(alimento);
            List<Alimento> Listado = AlimentosServicios.Listado();
            return RedirectToAction("Todos", Listado);
        }

        public ActionResult Todos()
        {
            List<Alimento> Listado = AlimentosServicios.Listado();
            return View(Listado);
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult Borrar(int Id)
        {
            AlimentosServicios.Borrar(Id);
            List<Alimento> Listado = AlimentosServicios.Listado();
            return RedirectToAction("Todos", Listado);
        }
    }
}