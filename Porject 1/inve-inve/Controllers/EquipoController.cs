using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Models;

namespace inve_inve.Controllers
{
    public class EquipoController
    {
        public EquipoController(){}
        //this one dont have any file asociated to ir
        
        //Crear equipos
        public Equipo CrearEquipoSolicitud(string nombre,int precio){
            Equipo EqSoli= new Equipo( nombre,precio);
            Console.WriteLine();
            Util.Util.GreenText("Equipo listo para solicitud");
            return EqSoli;
        }
        public Equipo CrearEquipoAprobado(Equipo EquipoPendiente){

           Equipo EquipoAprobado= new Equipo(EquipoPendiente.Nombre,GeneratePlaca(),Fecha.Now(),EquipoPendiente.Precio);
           Console.WriteLine("equipo aprobado Saftisfactoriamente");
           return EquipoAprobado;

        }
         //ir por cada uno de los empleados leyendo su lista de equipos
            //aqui aplicaremos algoritmo de ordenamiento
        public List<Equipo> AllEquipos(){
                List<Equipo> generalInventory= new List<Equipo>();
                //extract all the Equipos
                foreach (Empleado Employ in EmpleadoController.Empleados){
                    generalInventory.AddRange(Employ.Inventario);
                }
                Util.Sort.Heap.Sort(generalInventory);
                return generalInventory;

        }
        // console printing a inventory
        public void PrintLista(Empleado empleado){
            Console.WriteLine($"{"Placa",-12}|{"Nombre",-20}|{"Fecha",-20}|{"Precio",-15}");
            foreach (Equipo item in empleado.Inventario){
                Console.WriteLine($@"{item.Placa,12}{item.Nombre,20}{item.Fecha,20}{item.Precio,15:c}");
            }

        }
        public List<string> FormatAll(List<Equipo> eq){
            List<string> db=new List<string>();
            foreach (var equipo in eq){
                db.Add(equipo.ToString());
            }
            return db;
        }
        
        //random serial generation
        static int GeneratePlaca(){
         Random random = new Random();
        return random.Next(1, 200000);
    }

    }
}