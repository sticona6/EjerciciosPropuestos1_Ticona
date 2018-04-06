using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio07Controller : Controller
    {
        //Variables Pública 
        public static double pC1 = 11;
        public static double pC2 = 13;
        public static double pC3 = 15;
        public static double pC4 = 17;

        public static double pGm = 2;
        public static double pGg = 4;
        public static double pPm = 1.5;
        public static double pPg = 3;

        // GET: Ejercicio06
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ejercicio07(ClsEjercicio07 ObjEjercicio07)
        {
            //indicamos tru por que sera un check list

            if (ObjEjercicio07.Combo.Equals("C1"))
            {
                ObjEjercicio07.subtotal = pC1 * 0.18;
                if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGm + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGg + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGm + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") == true && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGg + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
            }

            else if (ObjEjercicio07.Combo.Equals("C2"))
            {
                ObjEjercicio07.subtotal = pC2 * 0.18;
                if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGm + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGg + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGm + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") == true && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGg + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
            }
            else if (ObjEjercicio07.Combo.Equals("C3"))
            {
                ObjEjercicio07.subtotal = pC3 * 0.18;
                if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGm + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGg + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGm + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") == true && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGg + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
            }
            else if (ObjEjercicio07.Combo.Equals("C4"))
            {
                ObjEjercicio07.subtotal = pC4 * 0.18;
                if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGm + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGg + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gm") && ObjEjercicio07.Papas.Equals("Pg"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGm);
                    ObjEjercicio07.Papas = Convert.ToString(pPg);
                    ObjEjercicio07.subtotal = pGm + pPg + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
                else if (ObjEjercicio07.Gaseosa.Equals("Gg") == true && ObjEjercicio07.Papas.Equals("Pm"))
                {
                    ObjEjercicio07.Gaseosa = Convert.ToString(pGg);
                    ObjEjercicio07.Papas = Convert.ToString(pPm);
                    ObjEjercicio07.subtotal = pGg + pPm + ObjEjercicio07.subtotal;
                    ObjEjercicio07.igv = ObjEjercicio07.subtotal * 0.18;
                    ObjEjercicio07.total = ObjEjercicio07.subtotal;
                }
            }
            return View("Ejercicio07", ObjEjercicio07);
        }
    }
}