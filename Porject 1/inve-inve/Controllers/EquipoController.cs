using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Models;

namespace inve_inve.Controllers
{
    public class EquipoController
    {
        //this one dont have any file asociated to ir
        
        //Crear equipos
        public Equipo CrearEquipoSolicitud(string nombre,int precio){
            Equipo EqSoli= new Equipo( nombre,precio);
            Console. WriteLine("Equipo listo para solicitud");
            return EqSoli;
        }
        public Equipo CrearEquipoAprobado(Equipo EquipoPendiente){

           Equipo EquipoAprobado= new Equipo(EquipoPendiente.Nombre,GeneratePlaca(),Fecha.Now(),EquipoPendiente.Precio);
           Console.WriteLine("equipo aprobado Saftisfactoriamente");
           return EquipoAprobado;

        }

        //random serial generation
        static int GeneratePlaca(){
         Random random = new Random();
        return random.Next(1000, 10000);
    }
        
    }
}