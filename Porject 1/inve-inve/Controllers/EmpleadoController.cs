using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Data;
using inve_inve.Models;

namespace inve_inve.Controllers;
    public class EmpleadoController{
        public static List<Empleado> Empleados= new List<Empleado>();//our database uploaded
        public static readonly string route=@"Data\Empleados.txt";
        public EmpleadoController(){}

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
        //export all to file
        public string SaveinFile(Empleado employ){
            string FileName= employ.Nombre+"_"+employ.Id;
            List<string> employed=new List<string>();
            employed.Add(employ.ToString());
            string customRoute= $@"Out\{FileName}.txt";
            FileIO.SaveFile(customRoute,employed);
            Console.WriteLine($"Avaliable file in {0}",customRoute);
            return customRoute;
        }

        //export to a format
        public List<string> FormatAll(){
            List<string> db=new List<string>();
            foreach (var employ in Empleados){
                db.Add(employ.ToString());
            }
            return db;
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

        //create empleado
        public void CrearEmpleado(long id,string nombre,  Fecha fecha, string ciudadNacimeinto, long tel, string email, Direccion dir){
            Empleados.Add(new Empleado( id, nombre,   fecha,  ciudadNacimeinto,  tel,  email,  dir));
            Util.Util.GreenText("Usuario creado satisfacoriamente");
        }
        public bool eliminarEmpleado(long Document){
            Empleado? emp= FindEmploye(Document);
            if (emp !=null)
            {
                Empleados.Remove(emp);
                return true;
            }
            else
            {
                Util.Util.RedText("Empleado no encontrado");
                return false;
            }
        }
        
}