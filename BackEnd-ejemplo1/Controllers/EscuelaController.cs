using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            ViewBag.Nombre = "Laura";
            ViewBag.correo = "LauraEs1928@gmail.com";
            ViewBag.Fecha = new DateTime(2001, 4, 10);

            return View();
        }
        public ActionResult Index2()
        {
            ViewData["Nombre"] = "Jonathan";
            ViewData["correo"] = "jona@gmail.com";
            ViewData["Fecha"] = new DateTime(2005, 05, 10); 

            return View();
        }

        public ActionResult Agregar( Trabajador emp )
        {

            return View(emp);
        }

        public ActionResult Agregar2(Trabajador emp)
        {
            var trab = new Trabajador()
            {
                Nombre = "José",
                Apellidos = "Lopez",
                FechaNacimiento = new DateTime(2000, 1, 1),
                Sueldo = 250,
                EsFijo = true
            }
            ;
            ViewBag.Trabajador = trab;

            return View(emp);
        }

        public List<SelectListItem> ObtenerListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text="Si",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text="No",
                    Value = "2"
                }
            };
        }

    }
}