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
        // export to a string list
        public void SaveAllinFile(List<string> formatedList){
            FileIO.SaveFile(route,formatedList);
        }
        public void SaveinFile(Empleado employ){
            string FileName= employ.Nombre+"_"+employ.Id;
            List<string> employed=new List<string>();
            employed.Add(employ.ToString());
            string customRoute= $@"Out\{FileName}";
            FileIO.SaveFile(customRoute,employed);
            Console.WriteLine("Avaliable file in {0}",customRoute);

        }

        //export to a format
        public List<string> FormatAll(){
            List<string> db=new List<string>();
            foreach (var employ in Empleados){
                db.Add(employ.ToString());
            }
            return db;
        }

        //ir por cada uno de los empleados leyendo su lista de equipos
            //aqui aplicaremos algoritmo de ordenamiento
            public void AllEquipos(){
                List<Equipo> generalInventory= new List<Equipo>();
                //extract all the Equipos
                foreach (Empleado Employ in Empleados){
                    generalInventory.Concat(Employ.Inventario);
                }
                //TODOsort all the list

            }
        //Find employe by Document
        public  Empleado FindEmploye(long Documento){
            foreach (Empleado item in Empleados)
            {
                if(item.Id== Documento){
                    return item;
                }
            }
            return null;
        }



        
}