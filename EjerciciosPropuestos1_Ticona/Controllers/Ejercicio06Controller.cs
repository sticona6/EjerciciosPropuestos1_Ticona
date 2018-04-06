using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio06Controller : Controller
    {
        // GET: Ejercicio06
        public ActionResult Index(ClsEjercicio06 ObjEjercicio06)
        {
            return View(ObjEjercicio06);
        }
    }
}