using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio08Controller : Controller
    {
        
        // GET: Ejercicio08
        public ActionResult Index(ClsEjercicio08 ObjEjercicio08)
        {
            
            return View(ObjEjercicio08);
        }
        public ActionResult Ejercicio08(ClsEjercicio08 ObjEjercicio08)
        {
            return View("Ejercicio08", ObjEjercicio08);
        }
        
    }
}