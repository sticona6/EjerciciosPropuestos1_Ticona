using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos1_Ticona.Models;

namespace EjerciciosPropuestos1_Ticona.Controllers
{
    public class Ejercicio03Controller : Controller
    {
        public int mayor, medio , menor , aux;

        // GET: Ejercicio03
        public ActionResult Index(ClsEjercicio03 ObjEjercicio03)
        {
            Random aleatorio = new Random();

            ObjEjercicio03.numero1 = aleatorio.Next(100);
            ObjEjercicio03.numero2 = aleatorio.Next(100);
            ObjEjercicio03.numero3 = aleatorio.Next(100);

            int[] num = new int[3];
            num[0] = ObjEjercicio03.numero1;
            num[1] = ObjEjercicio03.numero2;
            num[2] = ObjEjercicio03.numero3;

            mayor = num[0];
            menor = num[0];
           
            for (int i = 0; i < num.Length; i++) {
                if (num[i] < menor) {
                    menor = num[i];
                }
                else if (num[i] > mayor)
                 {
                    mayor = num[i];
                }
            }

            if (num[0]>= num[1]) {
                aux = num[1];
                num[1] = num[0];
                num[0] = aux;
            }
            if (num[1] >= num[2])
            {
                aux = num[2];
                num[2] = num[1];
                num[1] = aux;
            }
            if (num[0] >= num[1])
            {
                medio =num[0];
            }
            else {
                medio =num[1]; 
            }
            
            ObjEjercicio03.resultado = "El número mayor es : " + mayor + "  El número medio es : " + medio + "  El número menor es : " + menor;

            return View("Index",ObjEjercicio03);
        }
    }
}