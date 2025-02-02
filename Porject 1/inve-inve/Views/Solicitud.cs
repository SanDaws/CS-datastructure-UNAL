using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Controllers;
using inve_inve.Data;
using inve_inve.Models;
using inve_inve.Models.Enum;
using inve_inve.Util;
using inve_inve.Util.LinkedList;

namespace inve_inve.Views;
public class Solicitud
{
    CambioController cambioController;
    EmpleadoController empleadoController;
    EquipoController eq;
    public Solicitud()
    {
        cambioController = new CambioController();
        eq = new EquipoController();
        empleadoController = new EmpleadoController();

    }
    // menu and selections
    public void SoliMenu(){
        Util.Util.Title("Solicitudes", ConsoleColor.White);
        Console.WriteLine("""
            seleccione alguna de las opciones:
            1: solicitar adicion
            2: solicitar eliminacion
            3: Ver solicitudes personales
            """);
        if (Menu.Userloged.Rolecheck())
        {

            Console.WriteLine("""
            Opciones de administrador:
            4: Resolver Solicitudes pendientes
            5: Ver solicitud pendiente
            6: ver solicitudes completadas
            0:Volver
            """);
            AdminOptionSelector();

        }
        else
        {
            Console.WriteLine("0:Volver");
            OptionSelector();
        }



    }
    private void OptionSelector()
    {
        Console.WriteLine("oprima el numero de opcion");
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D1:
                AgregationForm();
                SoliMenu();
                break;
            case ConsoleKey.D2:
                EliminationForm();
                SoliMenu();
                break;
            case ConsoleKey.D3:
                MisSolicitudes(Menu.Userloged);
                SoliMenu();
                break;
            case ConsoleKey.D0:
                Util.Util.GreenText("volviendo");
                break;

            default:
                Console.WriteLine("opcion incorrecta");
                OptionSelector();
                break;
        }
    }
    private void AdminOptionSelector()
    {
        Console.WriteLine("oprima el numeor de opcion");
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D1:
                AgregationForm();
                SoliMenu();
                break;
            case ConsoleKey.D2:
                EliminationForm();
                SoliMenu();
                break;
            case ConsoleKey.D3:
                MisSolicitudes(Menu.Userloged);
                SoliMenu();
                break;
            case ConsoleKey.D4:
            SolvePendientes();
            SoliMenu();
                break;
            case ConsoleKey.D5:
            showPendientes();
            SoliMenu();
                break;
            case ConsoleKey.D6:
            showcompletados();

            SoliMenu();
                break;

            case ConsoleKey.D0:
                Util.Util.GreenText("Volviendo");
                break;

            default:
                Console.WriteLine("opcion incorrecta");
                AdminOptionSelector();
                break;
        }
    }
    //Solicitud forms
    public void AgregationForm(){
        Util.Util.Title("Solicitar agregacion de Equipo", ConsoleColor.Green);
        Console.Write("Nombre del equipo: ");
        string nombre = Util.Exceptions.AntiEMptyorNull();
        int precio = Util.Exceptions.safeInt("precio");

        Equipo solicitudeq = eq.CrearEquipoSolicitud(nombre, precio);
        cambioController.CreateAgregarionSolicitud(Menu.Userloged.Cedula.ToString(), solicitudeq);
        Console.WriteLine();
        Util.Util.GreenText("Solicitud enviada");
        Console.WriteLine();
        Console.WriteLine("oprina cualquier boton para volver");
        Console.ReadKey();

    }
    public void EliminationForm(){
        Util.Util.Title("Solicitar retiro de Equipo", ConsoleColor.Red);

    }
    public void MisSolicitudes(Credencial credencial)
    {
        LinkedList misSo=cambioController.showAllByDocument(credencial.Cedula);

       if(misSo!= null){
         cambioController.Conosoleprint(misSo);
         
         }
        Console.ReadKey();

    }
    //  add to the inventory of a employee
    // eliminate to the inventory
    //Resolve the  solitude
    //move to completado
    public void SolvePendientes(){
        while (CambioController.Pendientes.Cabeza != null)
        {
            Node nd = cambioController.resolveSolicitud();

            Console.WriteLine("""
            1: aceptar
            2: rechazar
            """);
            Console.WriteLine("oprima el numero de opcion");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Node newNodeComplete= cambioController.changeStatus(Estado.ACEPTADA,nd);
                    cambioController.MoveToCompletados(newNodeComplete);
                    cambioController.agregarAInventario(nd);
                    break;
                case ConsoleKey.D2:
                    Node newNodeDelete= cambioController.changeStatus(Estado.RECHAZADA,nd);
                    cambioController.MoveToCompletados(newNodeDelete);
                    cambioController.eliminarDeInventario(nd);
                    break;

                default:
                    Console.WriteLine("opcion incorrecta");
                    OptionSelector();
                    break;
            }
        }
    }
    public void showPendientes(){

        cambioController.Conosoleprint(CambioController.Pendientes);
        
        Console.ReadKey();
    }
    public void  showcompletados(){
        cambioController.Conosoleprint(CambioController.Completados);
        
        Console.ReadKey();
    }

}
