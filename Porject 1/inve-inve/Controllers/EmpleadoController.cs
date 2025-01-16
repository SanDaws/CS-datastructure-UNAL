using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Data;
using inve_inve.Models;

namespace inve_inve.Controllers;
    public class EmpleadoController{
        public static List<Empleado> Empleados;//our database uploaded
        public static readonly string route=@"Data\Control_de_cambios.txt";

        // import from a string list
        public void LoadDatabase(){
            List<string> db= FileIO.UploadFile(route);
            foreach (string EmpleadoFormat in db){
                Empleados.Add(new Empleado(EmpleadoFormat));
            }
            
        }
        //TODOir por cada uno de los empleados leyendo su lista de equipos
            //aqui aplicaremos algoritmo de ordenamiento

        //TODOcreate a agregation solicitude
        
        //TODOcreate a elimination solicitude
        //TODO export to a format
        //TODO export to a string list
        
}