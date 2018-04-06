using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio05Controller : Controller
    {
        // GET: Ejercicio05
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ejercicio05(ClsEjercicio05 ObjEjercicio05)
        {
            if (ObjEjercicio05.tipo.Equals("E"))
            {
                ObjEjercicio05.resultado = ObjEjercicio05.numero / 3.97;
                ObjEjercicio05.resultado = Math.Round(ObjEjercicio05.resultado, 2);
            }
            if (ObjEjercicio05.tipo.Equals("Y"))
            {
                ObjEjercicio05.resultado = ObjEjercicio05.numero * 32.86;
                ObjEjercicio05.resultado = Math.Round(ObjEjercicio05.resultado, 2);
            }
            if (ObjEjercicio05.tipo.Equals("D"))
            {
                ObjEjercicio05.resultado = ObjEjercicio05.numero / 3.23;
                ObjEjercicio05.resultado = Math.Round(ObjEjercicio05.resultado, 2);
            }
            if (ObjEjercicio05.tipo.Equals("P"))
            {
                ObjEjercicio05.resultado = ObjEjercicio05.numero * 188;
                ObjEjercicio05.resultado = Math.Round(ObjEjercicio05.resultado, 2);
            }
            return View("Ejercicio05", ObjEjercicio05);
        }
    }
}