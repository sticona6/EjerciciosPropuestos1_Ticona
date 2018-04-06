using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio01Controller : Controller
    {
        // GET: Ejercicio01
        public ActionResult Index(ClsEjercicio01 ObjEjercicio01)
        {
            ObjEjercicio01.nota = new int[10];
            Random result = new Random();
            ObjEjercicio01.estudiantes = new string[10];
            
            ObjEjercicio01.condicion = new string[10];
            for (int i=0;i<10;i++) {
                ObjEjercicio01.nota[i] = result.Next(0,20);
                if (ObjEjercicio01.nota[i] == 0 || ObjEjercicio01.nota[i] <= 10) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    ObjEjercicio01.condicion[i] = "desaprobado";
                    ObjEjercicio01.estudiantes[i] = ObjEjercicio01.nota[i] + " "+ ObjEjercicio01.condicion[i];
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ObjEjercicio01.condicion[i] = "aprobado";
                    ObjEjercicio01.estudiantes[i] = ObjEjercicio01.nota[i] + " " + ObjEjercicio01.condicion[i];
                }
            }
            return View("Index",ObjEjercicio01);
        }
    }
}