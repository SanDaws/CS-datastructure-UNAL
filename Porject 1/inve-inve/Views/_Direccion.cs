using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Models;
using inve_inve.Util;

namespace inve_inve.Views
{
    public class _Direccion
    {
        //string calle, string nomenclatura, string barrio, string ciudad, string edificio, string apto
        public static Direccion DireccionForm(){
            Console.Write("Calle: ");
            string calle= Util.Exceptions.AntiEMptyorNull();
            Console.Write("Nomencaltura: ");
            string nomenclatura= Util.Exceptions.AntiEMptyorNull();
            Console.Write("barrio: ");
            string barrio= Util.Exceptions.AntiEMptyorNull();
            Console.Write("ciudad: ");
            string ciudad= Util.Exceptions.AntiEMptyorNull();
            Console.Write("Edificio: ");
            string edificio= Console.ReadLine();
            Console.Write("apartamento: ");
            string apto= Console.ReadLine();
            Direccion dr=new Direccion(calle,nomenclatura,barrio,ciudad,edificio,apto);
            return dr;
        }
    }
}