using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Data;
using inve_inve.Models;
using inve_inve.Models.Enum;
using inve_inve.Util.LinkedList;
namespace inve_inve.Controllers
{
    public class CambioController
    {
        EmpleadoController emCon;
        public static readonly string route=@"Data\Control_de_cambios.txt";
        public static LinkedList Pendientes;
        public static LinkedList Completados;
        public CambioController(){
            emCon= new EmpleadoController();
        }


        //create a agregation solicitude
        public void CreateAgregarionSolicitud(string solicitanteCed, Equipo equipo){
            Pendientes.Agregar(new Cambio(solicitanteCed,equipo));                    
        }
        //create a elimination solicitude
        public void CreateEliminationSolicitud(string solicitanteCed, Equipo equipo, string justificacion){
            Pendientes.Agregar(new Cambio( solicitanteCed,  equipo,  justificacion));                    
        }
        //change status 
        public Node changeStatus(Estado estado){
            Node nd=Pendientes.eliminarCabezaSoft();
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
            Empleado solicitante= emCon.FindEmploye(long.Parse(cd.SolicitanteCed));
            solicitante.Inventario.Add(cd.Equipo);
                        
        }
        //Create as extracition to the inventory
        public void eliminarDeInventario(Node node){
            Cambio cd= (Cambio)node.Valor;
            Empleado solicitante= emCon.FindEmploye(long.Parse(cd.SolicitanteCed));
            solicitante.Inventario.Remove(cd.Equipo);
                        
        }


        // export to a string list
        public List<string> FormatAll(LinkedList ll){
            List<string> db=new List<string>();
            Node node= ll.Cabeza;
            while (node.Siguiente!=null)
            {
               db.Add(node.ToString());
               node=node.Siguiente;

            }
            return db;
        }
        public void LoadDatabase(){
            List<string> db= FileIO.UploadFile(route);
            foreach (string Solicitud in db){
            
                Cambio cb= new Cambio(Solicitud);

                if (cb.estado != Estado.PENDIENTE){
                    Pendientes.Agregar(cb);
                }
                else {
                    Completados.Agregar(cb);
                }
               
            }

        }
        //import all to a list
        public void SaveAllinFile(List<string> formatedList){
            FileIO.SaveFile(route,formatedList);
        }
        
    }
}