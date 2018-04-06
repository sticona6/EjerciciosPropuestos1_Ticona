using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio04Controller : Controller
    {
        // GET: Ejercicio04
        public ActionResult Index(ClsEjercicio04 ObjEjercicio04)
        {
            Random aleatorio = new Random();

            ObjEjercicio04.numero1 = aleatorio.Next(3);
            ObjEjercicio04.numero2 = aleatorio.Next(3);
            ObjEjercicio04.numero3 = aleatorio.Next(3);

            if ((ObjEjercicio04.numero1 == ObjEjercicio04.numero2) && (ObjEjercicio04.numero2 == ObjEjercicio04.numero3)&& (ObjEjercicio04.numero1 == ObjEjercicio04.numero3))
            {
                ObjEjercicio04.resultado = "Te ganaste gana 10, 000";

            }
            else if ((ObjEjercicio04.numero1 == ObjEjercicio04.numero2) || (ObjEjercicio04.numero2 == ObjEjercicio04.numero3) || (ObjEjercicio04.numero1 == ObjEjercicio04.numero3))
            {
                ObjEjercicio04.resultado = "Tienes grandes posibilidades...";
            }
            else if((ObjEjercicio04.numero1 != ObjEjercicio04.numero2) && (ObjEjercicio04.numero2 != ObjEjercicio04.numero3) && (ObjEjercicio04.numero1 != ObjEjercicio04.numero3))
            {
                ObjEjercicio04.resultado = "Sigue intentándolo suerte...";
            }
            return View("Index", ObjEjercicio04);
        }
    }
}