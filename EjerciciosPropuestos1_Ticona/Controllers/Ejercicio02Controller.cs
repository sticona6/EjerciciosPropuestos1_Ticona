using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio02Controller : Controller
    {
        public int p, n, ne;
        // GET: Ejercicio02
        public ActionResult Index(ClsEjercicio02 ObjEjercicio02)
        {
            ObjEjercicio02.numero = new int[10];
            return View(ObjEjercicio02);
        }

        public ActionResult Ejercicio02(ClsEjercicio02 ObjEjercicio02)
        {
            for (int i = 0; i < 10; i++)
            {
                if(ObjEjercicio02.numero[i] == 0)
                {
                    ne++;
                    //neutro
                }
                else if (ObjEjercicio02.numero[i] > 0)//número positivo
                {
                    p++;
                    ObjEjercicio02.positivo += Convert.ToString(ObjEjercicio02.numero[i]) + " , ";
                    //ObjEjercicio02.positivo [l] = Convert.ToString(ObjEjercicio02.numero[i]);
                }
                else//número negativo
                {
                    n++;
                    ObjEjercicio02.negativo += Convert.ToString(ObjEjercicio02.numero[i]) + " , ";
                    //ObjEjercicio02.negativo [j] = Convert.ToString(ObjEjercicio02.numero[i]);
                }
            }

            return View("Ejercicio02", ObjEjercicio02);
        }
    }
}