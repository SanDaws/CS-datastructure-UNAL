using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Models;

namespace inve_inve.Controllers
{
    public class DireccionController
    {
        //Create Direccion
        public Direccion CreateDireccion(string calle, string nomenclatura, string barrio, string ciudad, string edificio, string apto){
            calle = String.IsNullOrEmpty(calle) ? "None" : calle.Replace(" ", "_");
            nomenclatura = String.IsNullOrEmpty(nomenclatura) ? "None" : nomenclatura.Replace(" ", "_");
            barrio = String.IsNullOrEmpty(barrio) ? "None" : barrio.Replace(" ", "_");
            ciudad = String.IsNullOrEmpty(ciudad) ? "None" : ciudad.Replace(" ", "_");
            edificio = String.IsNullOrEmpty(edificio) ? "None" : edificio.Replace(" ", "_");
            apto = String.IsNullOrEmpty(apto) ? "None" : apto.Replace(" ", "_");
            Direccion dir= new Direccion(calle,nomenclatura,barrio,ciudad,edificio,apto);
            return dir;
        }
    }
}