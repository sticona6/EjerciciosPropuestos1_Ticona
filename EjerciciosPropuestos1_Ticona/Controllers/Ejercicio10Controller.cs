using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio10Controller : Controller
    {
        // GET: Ejercicio10
        public ActionResult Index(ClsEjercicio10 ObjEjercicio10)
        {
            //@Model.Total = @Model.Precio * @Model.Cantidad;
            ObjEjercicio10.Total = ObjEjercicio10.Precio * ObjEjercicio10.Cantidad;
            return View(ObjEjercicio10);
        }
    }
}