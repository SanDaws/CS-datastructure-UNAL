using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Data;
using inve_inve.Models;
using inve_inve.Models.Enum;
using inve_inve.Util;
using inve_inve.Util.LinkedList;
namespace inve_inve.Controllers
{
    public class CambioController
    {
        EmpleadoController emCon;
        EquipoController equipoController;
        public static readonly string route=@"Data\Control_de_cambios.txt";
        public static LinkedList Pendientes= new LinkedList();
        public static LinkedList Completados= new LinkedList();
        public CambioController(){
            emCon= new EmpleadoController();
            equipoController=new EquipoController();
        }


        //create a agregation solicitude
        public void CreateAgregarionSolicitud(string solicitanteCed, Equipo equipo){
            
            Pendientes.Agregar(new Cambio(solicitanteCed,equipo));    
            Console.WriteLine();   
            Util.Util.GreenText("Solicitud creada satisfactoriamente");                
        }
        //create a elimination solicitude
        public void CreateEliminationSolicitud(string solicitanteCed, Equipo equipo, string justificacion){
            Pendientes.Agregar(new Cambio( solicitanteCed,  equipo,  justificacion));                    
            Util.Util.GreenText("Solicitud creada satisfactoriamente");                
        }
        //change status 
        public Node changeStatus(Estado estado,Node nd){
            Cambio cb= (Cambio)nd.Valor;
            cb.estado= estado;
            return nd;
        }
        public void MoveToCompletados(Node node){
            Completados.Agregar(node);

        }
        //Create as agregation to the inventory
        public void agregarAInventario(Node node){
            Cambio cd= (Cambio)node.Valor;
            Equipo newEquipo= equipoController.CrearEquipoAprobado(cd.Equipo);
            Empleado solicitante= emCon.FindEmploye(long.Parse(cd.SolicitanteCed));
            solicitante.Inventario.Add(newEquipo);
                        
        }
        //Create as extracition to the inventory
        public void eliminarDeInventario(Node node){
            Cambio cd= (Cambio)node.Valor;
            Empleado solicitante= emCon.FindEmploye(long.Parse(cd.SolicitanteCed));
            solicitante.Inventario.Remove(cd.Equipo);
                        
        }
        public LinkedList showAllByDocument(long Document){
            LinkedList lpm= new LinkedList();
            Node node= Pendientes.Cabeza;
            if(node != null){
                while (node!=null)
            {
                Cambio cambio= (Cambio)node.Valor;
               if (long.Parse(cambio.SolicitanteCed) == Document)
               {
                lpm.Agregar(cambio);
                
               }
               node=node.Siguiente;

            }}
             node= Completados.Cabeza;
            if(node != null){
            while (node.Siguiente!=null)
            {
                Cambio cambio= (Cambio)node.Valor;
               if (long.Parse(cambio.SolicitanteCed) == Document)
               {
                lpm.Agregar(cambio);
                
               }
               node=node.Siguiente;

            }}
            if (lpm.Cabeza==null)
            {
                Util.Util.RedText("sin solicitudes");
                return null;
            }
            return lpm;

            

        }
        //show first Solicitud
        public Node resolveSolicitud(){

            Node nd= Pendientes.eliminarCabezaSoft();
            Cambio cb= (Cambio)nd.Valor;
            Console.WriteLine($"""
            Fecha de solicitud: {cb.FechaCreacion.ToString()}
            tipo:   {cb.tipo}
            Cedula: {cb.SolicitanteCed}
            Equipo: {cb.Equipo.Nombre}
            Precio: {cb.Equipo.Precio}
            Motivo: {cb.Justificacion}
            """);

            return nd;
        }

        // export to a string list
        public List<string> FormatAll(LinkedList ll){
            List<string> db=new List<string>();
            Node node= ll.Cabeza;

            if(node != null){
             while (node!=null){
                Cambio cb= (Cambio)node.Valor;
               db.Add(cb.ToString());
               node=node.Siguiente;
            }
            }
                
            return db;
        }
        public void LoadDatabase(){
            List<string> db= FileIO.UploadFile(route);
            if(db.Count != 0){
                foreach (string Solicitud in db){
            
                Cambio cb= new Cambio(Solicitud);

                if (cb.estado == Estado.PENDIENTE){
                    Pendientes.Agregar(cb);
                }
                else {
                    Completados.Agregar(cb);
                }
               
            }
            }
            

        }
        //import all to a file
        public void SaveAllinFile(List<string> formatedList){
            FileIO.SaveFile(route,formatedList);
        }
        public void SaveAllinFile(List<string> formatedList,string customRoute){
            FileIO.SaveFile(customRoute,formatedList);
        }
        public void Conosoleprint(LinkedList ll){
            
            Console.WriteLine($@"{"Solicitante",20}|{"tipo de solicitud",20}|{"Estado",12}|{"Nombre del equipo",30}");
            Node actual= ll.Cabeza;
            if (actual!=null)
            {
                
            while (actual!=null)
            {
                Cambio cambio= (Cambio)actual.Valor;
                Console.WriteLine($@"{cambio.SolicitanteCed,20}{cambio.tipo,20}{cambio.estado,12}{cambio.Equipo.Nombre,30}");
               actual=actual.Siguiente;

            }
            }
        
        }

    }
}